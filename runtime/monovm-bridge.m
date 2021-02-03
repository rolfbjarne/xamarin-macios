/* -*- Mode: C; tab-width: 8; indent-tabs-mode: t; c-basic-offset: 8 -*- */
/*
*  Authors: Rolf Bjarne Kvinge
*
*  Copyright (C) 2021 Microsoft Corp.
*
*/

/* Support code for using MonoVM */

#if !defined (CORECLR_RUNTIME)

#include <TargetConditionals.h>

#if !DOTNET && TARGET_OS_OSX
#define LEGACY_XAMARIN_MAC 1
#else
#define LEGACY_XAMARIN_MAC 0
#endif

#include "monotouch-debug.h"
#include "runtime-internal.h"
#include "xamarin/xamarin.h"
#include "xamarin/monovm-bridge.h"

#if !LEGACY_XAMARIN_MAC
void
xamarin_bridge_setup ()
{
	const char *c_bundle_path = xamarin_get_bundle_path ();

	setenv ("MONO_PATH", c_bundle_path, 1);

	setenv ("MONO_XMLSERIALIZER_THS", "no", 1);
	setenv ("MONO_REFLECTION_SERIALIZER", "yes", 1);

#if TARGET_OS_WATCH
	// watchOS can raise signals just fine...
	// we might want to move this inside mono at some point.
	signal (SIGPIPE, SIG_IGN);
#endif

#if TARGET_OS_WATCH || TARGET_OS_TV
	mini_parse_debug_option ("explicit-null-checks");
#endif
	// see http://bugzilla.xamarin.com/show_bug.cgi?id=820
	// take this line out once the bug is fixed
	mini_parse_debug_option ("no-gdb-backtrace");
}

void
xamarin_bridge_initialize ()
{
#if defined (__arm__) || defined(__aarch64__)
	xamarin_register_modules ();
#endif
	DEBUG_LAUNCH_TIME_PRINT ("\tAOT register time");

#ifdef DEBUG
	monotouch_start_debugging ();
	DEBUG_LAUNCH_TIME_PRINT ("\tDebug init time");
#endif
	
	if (xamarin_init_mono_debug)
		mono_debug_init (MONO_DEBUG_FORMAT_MONO);
	
	mono_install_assembly_preload_hook (xamarin_assembly_preload_hook, NULL);
	mono_install_load_aot_data_hook (xamarin_load_aot_data, xamarin_free_aot_data, NULL);

#ifdef DEBUG
	monotouch_start_profiling ();
	DEBUG_LAUNCH_TIME_PRINT ("\tProfiler config time");
#endif

	mono_set_signal_chaining (TRUE);
	mono_set_crash_chaining (TRUE);
	mono_install_unhandled_exception_hook (xamarin_unhandled_exception_handler, NULL);
	mono_install_ftnptr_eh_callback (xamarin_ftnptr_exception_handler);

	mono_jit_init_version ("MonoTouch", "mobile");
	/*
	  As part of mono initialization a preload hook is added that overrides ours, so we need to re-instate it here.
	  This is wasteful, but there's no way to manipulate the preload hook list except by adding to it.
	*/
	mono_install_assembly_preload_hook (xamarin_assembly_preload_hook, NULL);
	DEBUG_LAUNCH_TIME_PRINT ("\tJIT init time");
}
#endif // !LEGACY_XAMARIN_MAC

#if DOTNET
bool
xamarin_bridge_vm_initialize (int propertyCount, const char **propertyKeys, const char **propertyValues)
{
	int rv;

#if TARGET_OS_TV
	rv = 0;
	// Due to https://github.com/dotnet/runtime/issues/48508, we can't link with the .NET version of libmonosgen-2.0.dylib,
	// which means that we can't call monovm_initialize here (libxamarin.dylib fails native linking). Just ignore it for now.
	fprintf (stderr, "xamarin_vm_initialize (%i, %p, %p): Ignored due to https://github.com/dotnet/runtime/issues/48508.\n", propertyCount, propertyKeys, propertyValues);
#else

	rv = monovm_initialize (propertyCount, propertyKeys, propertyValues);

	LOG_MONOVM (stderr, "xamarin_vm_initialize (%i, %p, %p): rv: %i\n", propertyCount, propertyKeys, propertyValues, rv);
#endif

	return rv == 0;
}

#endif // DOTNET

/*
 * ToggleRef support
 */
// #define DEBUG_TOGGLEREF 1

static void
gc_register_toggleref (MonoObject *obj, id self, bool isCustomType)
{
	// COOP: This is an icall, at entry we're in unsafe mode. Managed memory is accessed, so we stay in unsafe mode.
	MONO_ASSERT_GC_UNSAFE;

#ifdef DEBUG_TOGGLEREF
	id handle = xamarin_get_nsobject_handle (obj);

	PRINT ("**Registering object %p handle %p RC %d flags: %i isCustomType: %i",
		obj,
		handle,
		(int) (handle ? [handle retainCount] : 0),
		xamarin_get_nsobject_flags (obj),
		isCustomType
		);
#endif
	mono_gc_toggleref_add (obj, TRUE);

	// Make sure the GCHandle we have is a weak one for custom types.
	if (isCustomType) {
		MONO_ENTER_GC_SAFE;
		xamarin_switch_gchandle (self, true);
		MONO_EXIT_GC_SAFE;
	}
}

static MonoToggleRefStatus
gc_toggleref_callback (MonoObject *object)
{
	// COOP: this is a callback called by the GC, so I assume the mode here doesn't matter
	MonoToggleRefStatus res;
	uint8_t flags = xamarin_get_nsobject_flags (object);

	res = xamarin_gc_toggleref_callback (flags, (xamarin_get_handle_func) xamarin_get_nsobject_handle, object);

	return res;
}

static void
gc_event_callback (MonoProfiler *prof, MonoGCEvent event, int generation)
{
	// COOP: this is a callback called by the GC, I believe the mode here doesn't matter.
	xamarin_gc_event (event);
}

void
xamarin_enable_new_refcount (void)
{
	mono_gc_toggleref_register_callback (gc_toggleref_callback);

	xamarin_add_internal_call ("Foundation.NSObject::RegisterToggleRef", (const void *) gc_register_toggleref);
	mono_profiler_install_gc (gc_event_callback, NULL);
}

#endif // !CORECLR_RUNTIME
