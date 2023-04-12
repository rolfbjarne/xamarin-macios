TOP=../../../..

TESTNAME=monotouchtest
include $(TOP)/tests/common/shared-dotnet.mk

export XAMARIN_LOG_MARSHALLED_EXCEPTIONS=1

managed-static-registrar msr:
	$(Q) $(MAKE) build-msr
	$(Q) $(MAKE) run-msr

build-msr:
	$(Q) rm -rf bin obj
	$(Q) $(MAKE) build CONFIG=ManagedStaticRegistrar

run-msr:
	$(Q) time $(MAKE) run-bare CONFIG=ManagedStaticRegistrar

build-msr-aot:
	$(Q) rm -rf bin obj
	$(Q) $(MAKE) build CONFIG=ManagedStaticRegistrar BUILD_ARGUMENTS=/p:RuntimeIdentifier=ios-arm64

registrar-tests:
	$(EXECUTABLE) --autostart --autoexit --test MonoTouchFixtures.ObjCRuntime.RegistrarTest

lldb: CONFIG=ManagedStaticRegistrar
lldb:
	MONO_DEBUG=disable_omit_fp,explicit-null-checks lldb -- $(EXECUTABLE) --autostart --autoexit $(TEST)

msr-compare:
	$(Q) $(MAKE) build CONFIG=ManagedStaticRegistrar
	$(Q) $(MAKE) build CONFIG=Debug
	-time $(MAKE) run-bare CONFIG=ManagedStaticRegistrar >& msr.log
	-time $(MAKE) run-bare CONFIG=Debug                  >& debug.log
