TOP = ../..

include $(TOP)/Make.config

build-all:
	$(MAKE) build-all -C "dont link/dotnet"
	$(MAKE) build-all -C "link all/dotnet"
	$(MAKE) build-all -C "link sdk/dotnet"
	$(MAKE) build-all -C "trimmode copy/dotnet"
	$(MAKE) build-all -C "trimmode link/dotnet"
