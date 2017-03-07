TOP=../..

include $(TOP)/Make.config

export MD_MTOUCH_SDK_ROOT=$(IOS_DESTDIR)/$(MONOTOUCH_PREFIX)
export XBUILD_FRAMEWORK_FOLDERS_PATH=$(IOS_DESTDIR)/Library/Frameworks/Mono.framework/External/xbuild-frameworks
export MSBuildExtensionsPath=$(IOS_DESTDIR)/Library/Frameworks/Mono.framework/External/xbuild

NUNIT_MSBUILD_DIR=$(TOP)/packages/NUnit.ConsoleRunner.3.5.0/tools/

all-local::
	$(MAKE) build
	$(MAKE) run-tests

run-tests:
	rm -f .failed-stamp
	$(SYSTEM_MONO) --debug $(NUNIT_MSBUILD_DIR)/nunit3-console.exe $(abspath $(CURDIR)/bin/Debug/sampletester.dll) "--result=$(abspath $(CURDIR)/TestResult.xml);format=nunit2" $(TEST_FIXTURE) --labels=All || touch $(CURDIR)/.failed-stamp
	@# Create an html file and tell MonkeyWrench to upload it (if we're running there)
	@[[ -z "$$BUILD_REPOSITORY" ]] || \
		( xsltproc $(TOP)/tests/HtmlTransform.xslt TestResult.xml  > index.html && \
		echo "@MonkeyWrench: AddFile: $$PWD/index.html")
	@[[ ! -e .failed-stamp ]]

build:
	$(Q) $(SYSTEM_MONO) /Library/Frameworks//Mono.framework/Versions/Current/lib/mono/nuget/NuGet.exe restore ../tests.sln
	$(SYSTEM_XBUILD) sampletester.csproj $(XBUILD_VERBOSITY)
	$(Q) rm -f .failed-stamp
