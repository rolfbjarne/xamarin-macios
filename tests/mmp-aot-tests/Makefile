TOP=../..
include $(TOP)/Make.config

ifdef INCLUDE_MAC
all-local:: run
endif

run:
	$(Q) rm -f $(CURDIR)/TestResult.html $(CURDIR)/TestResult.trx
	$(Q) $(DOTNET) test *.csproj --results-directory:. "--logger:console;verbosity=detailed" "--logger:trx;LogFileName=$(CURDIR)/TestResult.trx" "--logger:html;LogFileName=$(CURDIR)/TestResult.html" $(TEST_FIXTURE)

build:
	$(Q) $(DOTNET) build *.csproj $(XBUILD_VERBOSITY)

clean-local::
	$(Q) rm -Rf bin obj
