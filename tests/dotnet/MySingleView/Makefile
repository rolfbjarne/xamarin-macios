TOP=../../..

include $(TOP)/Make.config

build:
	$(DOTNET6) build /bl

prepare:
	$(MAKE) -C ..
	rm -Rf $(TOP)/tests/packages
	rm -Rf $(TOP)/tests/dotnet/packages
	$(MAKE) -C $(TOP) -j8 all
	$(MAKE) -C $(TOP) -j8 install

today:
	$(MAKE) prepare && $(MAKE) build; say today done
