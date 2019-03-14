TOP=../..

include $(TOP)/Make.config

NUNIT_MSBUILD_DIR=$(TOP)/packages/NUnit.ConsoleRunner.3.9.0/tools/

all-local::
	$(MAKE) build
	$(MAKE) run-tests

ifneq ($(TEST_CATEGORY),)
WHERE_CONDITION=/where "cat == $(TEST_CATEGORY)"
endif

TEST_RESULT=TestResult-$(shell date "+%Y%m%d-%H%M%S")

run-tests:
	@rm -f .failed-stamp
	mono64 --debug $(NUNIT_MSBUILD_DIR)/nunit3-console.exe $(WHERE_CONDITION) $(abspath $(CURDIR)/bin/Debug/sampletester.dll) "--result=$(abspath $(CURDIR)/$(TEST_RESULT).xml)" $${TEST_FIXTURE:+"$$TEST_FIXTURE"} --labels=All --inprocess || touch $(CURDIR)/.failed-stamp
	xsltproc HtmlReport.xslt "$(TEST_RESULT).xml" > "$(TEST_RESULT).html"
	$(CP) "$(TEST_RESULT).html" index.html
	@[[ ! -e .failed-stamp ]]

run-tests-system:
	$(MAKE) IOS_DESTDIR="/" IOS_TARGETDIR=/ MAC_DESTDIR=/ MAC_TARGETDIR=/

build:
	$(Q) $(SYSTEM_MONO) /Library/Frameworks//Mono.framework/Versions/Current/lib/mono/nuget/NuGet.exe restore
	$(SYSTEM_MSBUILD) sampletester.csproj $(MSBUILD_VERBOSITY)
	$(Q) rm -f .failed-stamp
