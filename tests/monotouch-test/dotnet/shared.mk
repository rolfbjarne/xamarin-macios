TOP=../../../..

TESTNAME=monotouchtest
include $(TOP)/tests/common/shared-dotnet.mk

managed-static-registrar msr:
	$(Q) rm -rf bin obj
	$(Q) $(MAKE) build CONFIG=ManagedStaticRegistrar
	$(Q) time $(MAKE) run-bare CONFIG=ManagedStaticRegistrar

registrar-tests:
	$(EXECUTABLE) --autostart --autoexit --test MonoTouchFixtures.ObjCRuntime.RegistrarTest

lldb:
	MONO_DEBUG=disable_omit_fp,explicit-null-checks lldb -- $(EXECUTABLE) --autostart --autoexit $(TEST)

msr-compare:
	$(Q) $(MAKE) build CONFIG=ManagedStaticRegistrar
	$(Q) $(MAKE) build CONFIG=Debug
	-time $(MAKE) run-bare CONFIG=ManagedStaticRegistrar >& msr.log
	-time $(MAKE) run-bare CONFIG=Debug                  >& debug.log
