/* -*- Mode: C; tab-width: 8; indent-tabs-mode: t; c-basic-offset: 8 -*- */
/*
*  Authors: Rolf Bjarne Kvinge
*
*  Copyright (C) 2021 Microsoft Corp.
*
*/

#if defined (CORECLR_RUNTIME)

#include <pthread.h>
#include <objc/runtime.h>
#include <sys/stat.h>
#include <dlfcn.h>
#include <inttypes.h>

#include "product.h"
#include "shared.h"
#include "delegates.h"
#include "runtime-internal.h"
#include "xamarin/xamarin.h"
#include "xamarin/coreclr-bridge.h"

#include "coreclrhost.h"

bool xamarin_loaded_coreclr = false;
unsigned int coreclr_domainId = 0;
void *coreclr_handle = NULL;

struct TrackedObjectInfo {
	id handle;
	enum NSObjectFlags flags;
};

void
xamarin_bridge_setup ()
{
}

void
xamarin_bridge_initialize ()
{
	xamarin_initialize_runtime_bridge ();
}

static bool reference_tracking_end = false;

void
xamarin_coreclr_reference_tracking_begin_end_callback ()
{
	LOG_CORECLR (stderr, "LOG: %s () reference_tracking_end: %i\n", __func__, reference_tracking_end);
	if (reference_tracking_end) {
		xamarin_gc_event (MONO_GC_EVENT_POST_START_WORLD);
	} else {
		xamarin_gc_event (MONO_GC_EVENT_PRE_STOP_WORLD);
	}
	reference_tracking_end = !reference_tracking_end;
}

static id
get_handle (void * ptr)
{
	return (id) ptr;
}

int
xamarin_coreclr_reference_tracking_is_referenced_callback (void* ptr)
{
	// COOP: this is a callback called by the GC, so I assume the mode here doesn't matter
	int rv = 0;
	struct TrackedObjectInfo *info = (struct TrackedObjectInfo *) ptr;
	enum NSObjectFlags flags = info->flags;
	id handle = info->handle;
	MonoToggleRefStatus res;

	res = xamarin_gc_toggleref_callback (flags, get_handle, handle);

	switch (res) {
	case MONO_TOGGLE_REF_DROP:
	case MONO_TOGGLE_REF_WEAK:
		rv = 0;
		break;
	case MONO_TOGGLE_REF_STRONG:
		rv = 1;
		break;
	default:
		fprintf (stderr, "LOG: INVALID toggle ref value: %i\n", res);
		break;
	}

	LOG_CORECLR (stderr, "LOG: %s (%p -> handle: %p flags: %i) => %i (res: %i)\n", __func__, ptr, handle, flags, rv, res);

	return rv;
}

void
xamarin_coreclr_reference_tracking_tracked_object_entered_finalization (void* ptr)
{
	LOG_CORECLR (stderr, "LOG: %s (%p)\n", __func__, ptr);
}

void
xamarin_coreclr_unhandled_exception_handler (void *context)
{
	GCHandle exception_gchandle = (GCHandle) context;

	fprintf (stderr, "LOG: %s (%p)\n", __func__, context);

	xamarin_process_managed_exception_gchandle (exception_gchandle);

	xamarin_assertion_message ("Failed to process managed exception.");
}

void
xamarin_enable_new_refcount ()
{
	// Nothing to do here.
}

static pthread_mutex_t monoobject_dict_lock;
static CFMutableDictionaryRef monoobject_dict = NULL;

static int _Atomic monoobject_count = 0;

struct monoobject_dict_type {
	char *managed;
	void *addresses [128];
	int frames;
	char *native;
};

#include <execinfo.h>
static char *
get_stacktrace (void **addresses, int frames)
{
	char** strs = backtrace_symbols (addresses, frames);

	size_t length = 0;
	int i;
	for (i = 0; i < frames; i++)
		length += strlen (strs [i]) + 1;
	length++;

	char *rv = (char *) calloc (1, length);
	char *buffer = rv;
	size_t left = length;
	for (i = 0; i < frames; i++) {
		snprintf (buffer, left, "%s\n", strs [i]);
		size_t slen = strlen (strs [i]) + 1;
		left -= slen;
		buffer += slen;
	}
	free (strs);
	return rv;
}

void
xamarin_bridge_log_monoobject (MonoObject *mobj, const char *stacktrace)
{
	struct monoobject_dict_type *value = (struct monoobject_dict_type *) calloc (1, sizeof (struct monoobject_dict_type));
	value->managed = xamarin_strdup_printf ("%s", stacktrace);
	value->frames = backtrace ((void **) &value->addresses, sizeof (value->addresses) / sizeof (&value->addresses [0]));

	pthread_mutex_lock (&monoobject_dict_lock);
	CFDictionarySetValue (monoobject_dict, mobj, value);
	pthread_mutex_unlock (&monoobject_dict_lock);

	atomic_fetch_add (&monoobject_count, 1);
}

void
xamarin_bridge_dump_monoobjects ()
{
	pthread_mutex_lock (&monoobject_dict_lock);
	unsigned int length = (unsigned int) CFDictionaryGetCount (monoobject_dict);
	MonoObject** keys = (MonoObject **) calloc (1, sizeof (void*) * length);
	char** values = (char **) calloc (1, sizeof (char*) * length);
	CFDictionaryGetKeysAndValues (monoobject_dict, (const void **) keys, (const void **) values);
	fprintf (stderr, "There were %i MonoObjects created, and %i were not freed.\n", (int) monoobject_count, (int) length);
	unsigned int items_to_show = length > 10 ? 10 : length;
	if (items_to_show > 0) {
		fprintf (stderr, "Showing the first %i MonoObjects:\n", items_to_show);
		for (unsigned int i = 0; i < items_to_show; i++) {
			MonoObject *obj = keys [i];
			struct monoobject_dict_type *value = (struct monoobject_dict_type *) values [i];
			if (value->native == NULL)
				value->native = get_stacktrace (value->addresses, value->frames);
			fprintf (stderr, "Object %i/%i %p RC: %i\n", i + 1, (int) length, obj, (int) obj->reference_count);
			fprintf (stderr, "\t%s\nNative stack trace:\n%s", value->managed, value->native);
		}
	} else {
		fprintf (stderr, "✅ No leaked MonoObjects!\n");
	}
	pthread_mutex_unlock (&monoobject_dict_lock);

	free (keys);
	free (values);
}


static void
monoobject_dict_free_value (CFAllocatorRef allocator, const void *value)
{
	struct monoobject_dict_type* v = (struct monoobject_dict_type *) value;
	xamarin_free (v->managed);
	if (v->native)
		free (v->native);
	free (v);
}

// static void *
// dump_monoobj (void *context)
// {
// 	while (1) {
// 		sleep (15);
// 		xamarin_bridge_dump_monoobjects ();
// 	}
// }

bool
xamarin_bridge_vm_initialize (int propertyCount, const char **propertyKeys, const char **propertyValues)
{
	int rv;

	const char *executablePath = [[[[NSBundle mainBundle] executableURL] path] UTF8String];
	rv = coreclr_initialize (
		executablePath,
		xamarin_executable_name,
		propertyCount,
		propertyKeys,
		propertyValues,
		&coreclr_handle,
		&coreclr_domainId
		);

	LOG_CORECLR (stderr, "xamarin_vm_initialize (%i, %p, %p): rv: %i domainId: %i handle: %p\n", propertyCount, propertyKeys, propertyValues, rv, coreclr_domainId, coreclr_handle);

	return rv == 0;
}

static void
xamarin_load_coreclr ()
{
	if (xamarin_loaded_coreclr)
		return;
	xamarin_loaded_coreclr = true;

	// Initialize some debug stuff
	pthread_mutexattr_t attr;
	pthread_mutexattr_init (&attr);
	pthread_mutexattr_settype (&attr, PTHREAD_MUTEX_RECURSIVE);
	pthread_mutex_init (&monoobject_dict_lock, &attr);
	pthread_mutexattr_destroy (&attr);

	CFDictionaryValueCallBacks value_callbacks = { 0 };
	value_callbacks.release = monoobject_dict_free_value;
	monoobject_dict = CFDictionaryCreateMutable (kCFAllocatorDefault, 0, NULL, &value_callbacks);

	LOG_CORECLR (stderr, "xamarin_load_coreclr ()\n");
}

MONO_API void
xamarin_bridge_mono_gc_collect (int generation)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_gc_collect (%i)\n", generation);
}

MONO_API MonoClassField *
xamarin_bridge_mono_class_get_field_from_name (MonoClass * klass, const char * name)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_get_field_from_name (%p, %s) => assert\n", klass, name);
	xamarin_assertion_message ("xamarin_bridge_mono_class_get_field_from_name not implemented\n");
}

MONO_API mono_bool
xamarin_bridge_mono_class_is_assignable_from (MonoClass * klass, MonoClass * oklass)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_is_assignable_from (%p, %p) => assert\n", klass, oklass);
	xamarin_assertion_message ("xamarin_bridge_mono_class_is_assignable_from not implemented\n");
}

MONO_API MonoClass *
xamarin_bridge_mono_class_get_element_class (MonoClass * klass) // mono_class_get_element_class needs REVIEW
{
	MonoClass *rv = xamarin_bridge_get_element_class (klass);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_get_element_class (%p = %s) => %p = %s = %p\n", klass, klass->fullname, rv, rv->fullname, rv->gchandle);
	return rv;
}

MONO_API const char *
xamarin_bridge_mono_class_get_namespace (MonoClass * klass)
{
	char *rv = xamarin_bridge_type_get_name_space (klass);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_get_namespace (%p) => %s\n", klass, rv);
	return rv;
}

MONO_API const char *
xamarin_bridge_mono_class_get_name (MonoClass * klass)
{
	char *rv = xamarin_bridge_type_get_name (klass);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_get_name (%p) => %s\n", klass, rv);
	return rv;
}

MONO_API MonoClass *
xamarin_bridge_mono_class_get_parent (MonoClass * klass)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_get_parent (%p) => assert\n", klass);
	xamarin_assertion_message ("xamarin_bridge_mono_class_get_parent not implemented\n");
}

MONO_API mono_bool
xamarin_bridge_mono_class_is_subclass_of (MonoClass * klass, MonoClass * klassc, mono_bool check_interfaces)
{
	bool rv = xamarin_bridge_is_subclass_of (klass, klassc, check_interfaces);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_is_subclass_of (%p = %s, %p = %s, %i) => %i\n", klass, klass->fullname, klassc, klassc->fullname, check_interfaces, rv);

	return rv;
}

MONO_API MonoType *
xamarin_bridge_mono_class_get_type (MonoClass * klass)
{
	MonoType *rv = klass;
	xamarin_mono_object_retain (rv);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_get_type (%p) => %p = %p\n", klass, rv, rv);
	return rv;
}

MONO_API MonoClass *
xamarin_bridge_mono_class_get_nullable_param (MonoClass * klass)
{
	MonoClass *rv = xamarin_bridge_get_nullable_element_type (klass);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_get_nullable_param (%p) => %p = %s = %p\n", klass, rv, rv->fullname, rv->gchandle);
	return rv;
}

MONO_API char *
xamarin_bridge_mono_method_full_name (MonoMethod * method, mono_bool signature)
{
	char *rv = xamarin_bridge_get_method_full_name (method);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_method_full_name (%p, %i) => %s\n", method, signature, rv);
	return rv;

}

MONO_API void
xamarin_bridge_mono_raise_exception (MonoException * ex)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_raise_exception (%p)\n", ex);

	// print out the exception
	char * str = xamarin_bridge_tostring (ex->gchandle);
	LOG_CORECLR (stderr, "--------------------------------------------------\n");
	LOG_CORECLR (stderr, "Throwing managed exception through native code: %s\n", str);
	LOG_CORECLR (stderr, "--------------------------------------------------\n");
	mono_free (str);

	// throw the exception
	xamarin_bridge_throw_exception (ex->gchandle);

	// we should never get here
	xamarin_assertion_message ("xamarin_bridge_mono_raise_exception did not throw/assert?\n");
}

// Return value: a retained MonoString* which the caller must release.
MONO_API MonoString *
xamarin_bridge_mono_string_new (MonoDomain * domain, const char * text)
{
	MonoString *rv = xamarin_bridge_new_string (text);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_string_new (%p, %s) => %p = %p\n", domain, text, rv, rv->gchandle);
	return rv;
}

MONO_API void *
xamarin_bridge_mono_object_unbox (MonoObject * obj)
{
	if (obj->struct_value == NULL) {
		xamarin_assertion_message ("xamarin_bridge_mono_object_unbox (%p) => no struct value?\n");
	}

	void *rv = obj->struct_value;
	LOG_CORECLR (stderr, "xamarin_bridge_mono_object_unbox (%p) => %p => %p\n", obj, rv, rv != NULL ? *(void **) rv : NULL);
	return rv;
}

// Return value: 'obj' if 'obj' is an instance of 'klass'.
MONO_API MonoObject *
xamarin_bridge_mono_object_isinst (MonoObject * obj, MonoClass * klass)
{
	bool rv = xamarin_bridge_isinstance (obj->gchandle, klass->gchandle);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_object_isinst (%p => %s, %p => %s) => %i\n", obj, obj->type_name, klass, klass->fullname, rv);
	return rv ? obj : NULL;
}

bool
xamarin_bridge_coreclr_object_isinst (GCHandle obj, MonoClass * klass)
{
	bool rv = xamarin_bridge_isinstance (obj, klass->gchandle);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_object_isinst (%p, %p => %s) => %i\n", obj, klass, klass->fullname, rv);
	return rv;
}

MONO_API MonoClass *
xamarin_bridge_mono_object_get_class (MonoObject * obj) // NEEDS REVIEW (already done maybe?)
{
	MonoClass *rv = xamarin_bridge_mono_object_get_type (obj);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_object_get_class (%p) => %p = %s\n", obj, rv, rv->fullname);

	return rv;
}

MonoClass *
xamarin_bridge_coreclr_gchandle_get_class (GCHandle obj) // NEEDS REVIEW
{
	MonoType *type = xamarin_gchandle_unwrap (obj);
	MonoClass *rv = xamarin_bridge_object_get_type (type);

	xamarin_mono_object_release (&type);

	LOG_CORECLR (stderr, "xamarin_bridge_coreclr_gchandle_get_class (%p) => %p = %s\n", obj, rv, rv->fullname);

	return rv;
}

MONO_API void
xamarin_bridge_mono_field_get_value (MonoObject * obj, MonoClassField * field, void * value)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_field_get_value (%p, %p, %p) => assert\n", obj, field, value);
	xamarin_assertion_message ("xamarin_bridge_mono_field_get_value not implemented\n");
}

MONO_API void
xamarin_bridge_mono_profiler_install (MonoProfiler * prof, MonoProfileFunc shutdown_callback)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_profiler_install (%p, %p) => IGNORE\n", prof, shutdown_callback);
}

MONO_API void
xamarin_bridge_mono_profiler_install_thread (MonoProfileThreadFunc start, MonoProfileThreadFunc end)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_profiler_install_thread (%p, %p) => IGNORE\n", start, end);
}

MONO_API void
xamarin_bridge_mono_profiler_install_gc (MonoProfileGCFunc callback, MonoProfileGCResizeFunc heap_resize_callback)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_profiler_install_gc (%p, %p) => IGNORE\n", callback, heap_resize_callback);
}

MONO_API void
xamarin_bridge_mono_profiler_load (const char * desc)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_profiler_load (%s) => IGNORE\n", desc);
}

MONO_API mono_bool
xamarin_bridge_mono_thread_is_foreign (MonoThread * thread)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_thread_is_foreign (%p) => assert\n", thread);
	xamarin_assertion_message ("xamarin_bridge_mono_thread_is_foreign not implemented\n");
}

MONO_API MonoThread * 
xamarin_bridge_mono_thread_current (void)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_thread_current () => assert\n");
	xamarin_assertion_message ("xamarin_bridge_mono_thread_current not implemented\n");
}

MONO_API MonoThread *
xamarin_bridge_mono_thread_attach (MonoDomain * domain)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_thread_attach (%p) => assert\n", domain);
	xamarin_assertion_message ("xamarin_bridge_mono_thread_attach not implemented\n");
}

MONO_API mono_bool
xamarin_bridge_mono_thread_detach_if_exiting (void)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_thread_detach_if_exiting () => IGNORE\n");
	return false;
}

MONO_API void
xamarin_bridge_mono_set_assemblies_path (const char * path)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_set_assemblies_path (%s) => IGNORE\n", path);
}

MONO_API MonoImage *
xamarin_bridge_mono_assembly_get_image (MonoAssembly * assembly)
{
	xamarin_assertion_message ("%s not implemented\n", __func__);
}

MONO_API MonoAssemblyName *
xamarin_bridge_mono_assembly_name_new (const char * name)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_assembly_name_new (%s) => assert\n", name);
	xamarin_assertion_message ("xamarin_bridge_mono_assembly_name_new not implemented\n");
}

MONO_API void
xamarin_bridge_mono_assembly_name_free (MonoAssemblyName * aname)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_assembly_name_free (%p) => IGNORE\n", aname);
}

MONO_API MonoAssembly *
xamarin_bridge_mono_assembly_loaded (MonoAssemblyName * aname)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_assembly_loaded (%p) => assert\n", aname);
	xamarin_assertion_message ("xamarin_bridge_mono_assembly_loaded not implemented\n");
}

MONO_API void
xamarin_bridge_mono_register_machine_config (const char * config_xml)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_register_machine_config (%s) => IGNORE\n", config_xml);
}

MONO_API void
xamarin_bridge_mono_set_dirs (const char * assembly_dir, const char * config_dir)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_set_dirs (%s, %s) => IGNORE\n", assembly_dir, config_dir);
}

MONO_API const char *
xamarin_bridge_mono_assembly_name_get_name (MonoAssemblyName * aname)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_assembly_name_get_name (%p) => assert\n", aname);
	xamarin_assertion_message ("xamarin_bridge_mono_assembly_name_get_name not implemented\n");
}

MONO_API const char *
xamarin_bridge_mono_assembly_name_get_culture (MonoAssemblyName * aname)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_assembly_name_get_culture (%p) => assert\n", aname);
	xamarin_assertion_message ("xamarin_bridge_mono_assembly_name_get_culture not implemented\n");
}

MONO_API void
xamarin_bridge_mono_install_assembly_preload_hook (MonoAssemblyPreLoadFunc func, void * user_data)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_install_assembly_preload_hook (%p, %p) => IGNORE\n", func, user_data);
}

MONO_API MonoAssemblyName *
xamarin_bridge_mono_assembly_get_name (MonoAssembly * assembly)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_assembly_get_name (%p) => assert\n", assembly);
	xamarin_assertion_message ("xamarin_bridge_mono_assembly_get_name not implemented\n");
}

MONO_API void
xamarin_bridge_mono_add_internal_call (const char * name, const void * method)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_add_internal_call (%s, %p) => IGNORE\n", name, method);
}

MONO_API void
xamarin_bridge_mono_dangerous_add_raw_internal_call (const char * name, const void * method)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_dangerous_add_raw_internal_call (%s, %p) => IGNORE\n", name, method);
}

MONO_API void
xamarin_bridge_mono_dllmap_insert (MonoImage * assembly, const char * dll, const char * func, const char * tdll, const char * tfunc)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_dllmap_insert (%p, %p, %p, %p, %p) => IGNORE\n", assembly, dll, func, tdll, tfunc);
}

MONO_API MonoDomain *
xamarin_bridge_mono_domain_get (void)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_domain_get () => IGNORE\n");
	return NULL;
}

MONO_API MonoClass *
xamarin_bridge_mono_get_intptr_class (void)
{
	static MonoClass *rv = NULL;

	if (rv == NULL)
		rv = xamarin_bridge_lookup_class (XamarinLookupTypes_System_IntPtr);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_get_intptr_class () => %p = %s\n", rv, rv->name);
	return rv;
}

MONO_API MonoClass *
xamarin_bridge_mono_get_string_class (void)
{
	static MonoClass *rv = NULL;

	if (rv == NULL)
		rv = xamarin_bridge_lookup_class (XamarinLookupTypes_System_String);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_get_string_class () => %p = %s\n", rv, rv->name);
	return rv;
}

MONO_API MonoImage *
xamarin_bridge_mono_get_corlib (void)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_get_corlib () => IGNORE (NULL)\n");
	return NULL;
}

MONO_API MonoClass *
xamarin_bridge_mono_get_array_class (void)
{
	static MonoClass *rv = NULL;

	if (rv == NULL)
		rv = xamarin_bridge_lookup_class (XamarinLookupTypes_System_Array);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_get_array_class () => %p = %s\n", rv, rv->name);
	return rv;
}

MONO_API MonoDomain *
xamarin_bridge_mono_get_root_domain (void)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_get_root_domain () => assert\n");
	xamarin_assertion_message ("xamarin_bridge_mono_get_root_domain not implemented\n");
}

MONO_API void
xamarin_bridge_mono_domain_set_config (MonoDomain * domain, const char * base_dir, const char * config_file_name)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_domain_set_config (%p, %s, %s) => assert\n", domain, base_dir, config_file_name);
	xamarin_assertion_message ("xamarin_bridge_mono_domain_set_config not implemented\n");
}

MONO_API MonoReflectionMethod *
xamarin_bridge_mono_method_get_object (MonoDomain * domain, MonoMethod * method, MonoClass * refclass)
{
	MonoReflectionMethod *rv = method;

	xamarin_mono_object_retain (rv);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_method_get_object (%p, %p, %p) => %p\n", domain, method, refclass, rv);

	return rv;
}

void
xamarin_install_nsautoreleasepool_hooks ()
{
	// https://github.com/xamarin/xamarin-macios/issues/11256
	fprintf (stderr, "TODO: add support for wrapping all threads with NSAutoreleasePools.\n");
}

void
mono_runtime_set_pending_exception (MonoException *exc, mono_bool overwrite)
{
	LOG_CORECLR (stderr, "%s (%p, %i)\n", __func__, exc, overwrite);
	xamarin_bridge_set_pending_exception (exc);
}

void
xamarin_handle_bridge_exception (GCHandle gchandle, const char *method)
{
	if (gchandle == INVALID_GCHANDLE)
		return;

	if (method == NULL)
		method = "<unknown method>";

	GCHandle exception_gchandle = INVALID_GCHANDLE;
	char * str = xamarin_bridge_tostring (gchandle, &exception_gchandle);
	fprintf (stderr, "xamarin_handle_bridge_exception (%p, %s) => %s\n", gchandle, method, str);
	if (exception_gchandle != INVALID_GCHANDLE)
		xamarin_assertion_message ("xamarin_bridge_tostring threw an exception");
	LOG_CORECLR (stderr, "%s threw an exception: %s\n", method, str);
	mono_free (str);
	xamarin_assertion_message ("%s threw an exception: %s", method, str);
}

MONO_API MonoType *
xamarin_bridge_mono_reflection_type_get_type (MonoReflectionType * reftype) // MUST REVIEW
{
	MonoType *rv = reftype;
	xamarin_mono_object_retain (rv);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_reflection_type_get_type (%p) => %p\n", reftype, rv);
	return rv;
}

MONO_API MonoType *
xamarin_bridge_mono_signature_get_return_type (MonoMethodSignature * sig)
{
	MonoType *rv = xamarin_bridge_get_method_returntype (sig->method);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_signature_get_return_type (%p) => %p = %s\n", sig, rv->gchandle, rv->name);

	return rv;
}

MONO_API int
xamarin_bridge_mono_type_get_type (MonoType * type)
{
	char *fullname = xamarin_bridge_get_type_fullname (type);
	MonoTypeEnum rv = MONO_TYPE_UNKNOWN;

	if (fullname == NULL) {
		rv = MONO_TYPE_VOID;
	} else if (!strcmp (fullname, "System.Byte")) {
		rv = MONO_TYPE_U1;
	} else if (!strcmp (fullname, "System.SByte")) {
		rv = MONO_TYPE_I1;
	} else if (!strcmp (fullname, "System.UInt16")) {
		rv = MONO_TYPE_U2;
	} else if (!strcmp (fullname, "System.Int16")) {
		rv = MONO_TYPE_I2;
	} else if (!strcmp (fullname, "System.UInt32")) {
		rv = MONO_TYPE_U4;
	} else if (!strcmp (fullname, "System.Int32")) {
		rv = MONO_TYPE_I4;
	} else if (!strcmp (fullname, "System.UInt64")) {
		rv = MONO_TYPE_U8;
	} else if (!strcmp (fullname, "System.Int64")) {
		rv = MONO_TYPE_I8;
	} else if (!strcmp (fullname, "System.Single")) {
		rv = MONO_TYPE_R4;
	} else if (!strcmp (fullname, "System.Double")) {
		rv = MONO_TYPE_R8;
	} else if (!strcmp (fullname, "System.Boolean")) {
		rv = MONO_TYPE_BOOLEAN;
	} else if (!strcmp (fullname, "System.String")) {
		rv = MONO_TYPE_STRING;
	} else {
		rv = MONO_TYPE_UNKNOWN;
	}

	xamarin_free (fullname);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_type_get_type (%p = %s) => %i\n", type, fullname, (int) rv);

	return rv;
}

MONO_API mono_bool
xamarin_bridge_mono_is_debugger_attached (void)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_is_debugger_attached () => IGNORE\n");
	return false;
}

MONO_API void
xamarin_bridge_mono_config_parse_memory (const char * buffer)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_config_parse_memory (%s) => IGNORE\n", buffer);
}

MONO_API int
xamarin_bridge_mono_gc_max_generation (void)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_gc_max_generation () => 2\n");
	return 2;
}

MONO_API MonoException *
xamarin_bridge_mono_get_exception_execution_engine (const char * msg)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_get_exception_execution_engine (%s) => assert\n", msg);
	xamarin_assertion_message ("xamarin_bridge_mono_get_exception_execution_engine not implemented\n");
}

MONO_API MonoException *
xamarin_bridge_mono_exception_from_name_msg (MonoImage * image, const char * name_space, const char * name, const char * msg)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_exception_from_name_msg (%p, %s, %s, %s) => assert\n", image, name_space, name, msg);
	xamarin_assertion_message ("xamarin_bridge_mono_exception_from_name_msg not implemented\n");
}

MONO_API MonoException *
xamarin_bridge_mono_get_exception_out_of_memory (void)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_get_exception_out_of_memory () => assert\n");
	xamarin_assertion_message ("xamarin_bridge_mono_get_exception_out_of_memory not implemented\n");
}

MONO_API char *
xamarin_bridge_mono_get_runtime_build_info (void)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_get_runtime_build_info () => assert\n");
	xamarin_assertion_message ("xamarin_bridge_mono_get_runtime_build_info not implemented\n");
}

MONO_API MonoDomain *
xamarin_bridge_mono_jit_init_version (const char * root_domain_name, const char * runtime_version)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_jit_init_version (%s, %s) => IGNORE\n", root_domain_name, runtime_version);
	return NULL;
}

MONO_API MonoDomain *
xamarin_bridge_mono_jit_init (const char * file)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_jit_init (%s) => assert\n", file);
	xamarin_assertion_message ("xamarin_bridge_mono_jit_init not implemented\n");
}

MONO_API void
xamarin_bridge_mono_jit_parse_options (int argc, char** argv)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_jit_parse_options (%i, %p) => assert\n", argc, argv);
	xamarin_assertion_message ("xamarin_bridge_mono_jit_parse_options not implemented\n");
}

MONO_API void
xamarin_bridge_mono_jit_set_aot_mode (MonoAotMode mode)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_jit_set_aot_mode (%i) => assert\n", mode);
	xamarin_assertion_message ("xamarin_bridge_mono_jit_set_aot_mode not implemented\n");
}

MONO_API void
xamarin_bridge_mono_set_signal_chaining (mono_bool chain_signals)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_set_signal_chaining (%i) => IGNORE\n", chain_signals);
}

MONO_API void
xamarin_bridge_mono_set_crash_chaining (mono_bool chain_signals)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_set_crash_chaining (%i) => IGNORE\n", chain_signals);
}

MONO_API void
xamarin_bridge_mono_jit_set_trace_options (const char * option)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_jit_set_trace_options (%s) => IGNORE\n", option);
}

MONO_API void*
xamarin_bridge_mono_jit_thread_attach (MonoDomain * domain)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_jit_thread_attach (%p) => IGNORE\n", domain);
	return NULL;
}

MONO_API void
xamarin_bridge_mono_install_unhandled_exception_hook (MonoUnhandledExceptionFunc func, gpointer user_data)
{
	LOG_CORECLR (stderr, "%s (%p, %p) => IGNORE\n", __func__, func, user_data);
}

MONO_API void
xamarin_bridge_mono_install_load_aot_data_hook (MonoLoadAotDataFunc load_func, MonoFreeAotDataFunc free_func, gpointer user_data)
{
	LOG_CORECLR (stderr, "%s (%p, %p, %p) => IGNORE\n", __func__, load_func, free_func, user_data);
}

MONO_API void
xamarin_bridge_mono_trace_set_log_handler (MonoLogCallback callback, void * user_data)
{
	LOG_CORECLR (stderr, "%s (%p, %p) => IGNORE\n", __func__, callback, user_data);
}

MONO_API void
xamarin_bridge_mono_trace_set_print_handler (MonoPrintCallback callback)
{
	LOG_CORECLR (stderr, "%s (%p) => IGNORE\n", __func__, callback);
}

MONO_API void
xamarin_bridge_mono_trace_set_printerr_handler (MonoPrintCallback callback)
{
	LOG_CORECLR (stderr, "%s (%p) => IGNORE\n", __func__, callback);
}

MONO_API void*
xamarin_bridge_mono_threads_enter_gc_unsafe_region (void ** stackdata)
{
	LOG_CORECLR (stderr, "%s (%p) => assert\n", __func__, stackdata);
	xamarin_assertion_message ("xamarin_bridge_mono_threads_enter_gc_unsafe_region not implemented\n");
}

MONO_API void
xamarin_bridge_mono_threads_exit_gc_unsafe_region (void * cookie, void ** stackdata)
{
	LOG_CORECLR (stderr, "%s (%p, %p) => assert\n", __func__, cookie, stackdata);
	xamarin_assertion_message ("xamarin_bridge_mono_threads_exit_gc_unsafe_region not implemented\n");
}

MONO_API void*
xamarin_bridge_mono_threads_enter_gc_safe_region (void ** stackdata)
{
	LOG_CORECLR (stderr, "%s (%p) => assert\n", __func__, stackdata);
	xamarin_assertion_message ("xamarin_bridge_mono_threads_enter_gc_safe_region not implemented\n");
}

MONO_API void
xamarin_bridge_mono_threads_exit_gc_safe_region (void * cookie, void ** stackdata)
{
	LOG_CORECLR (stderr, "%s (%p, %p) => assert\n", __func__, cookie, stackdata);
	xamarin_assertion_message ("xamarin_bridge_mono_threads_exit_gc_safe_region not implemented\n");
}

MONO_API void
xamarin_bridge_mono_threads_assert_gc_safe_region (void)
{
	LOG_CORECLR (stderr, "%s () => assert\n", __func__);
	xamarin_assertion_message ("xamarin_bridge_mono_threads_assert_gc_safe_region not implemented\n");
}

MONO_API void
xamarin_bridge_mono_threads_assert_gc_unsafe_region (void)
{
	LOG_CORECLR (stderr, "%s () => assert\n", __func__);
	xamarin_assertion_message ("xamarin_bridge_mono_threads_assert_gc_unsafe_region not implemented\n");
}

MONO_API void
xamarin_bridge_mono_threads_assert_gc_starting_region (void)
{
	LOG_CORECLR (stderr, "%s () => assert\n", __func__);
	xamarin_assertion_message ("xamarin_bridge_mono_threads_assert_gc_starting_region not implemented\n");
}

MONO_API void*
xamarin_bridge_mono_thread_info_current_unchecked (void)
{
	LOG_CORECLR (stderr, "%s () => assert\n", __func__);
	xamarin_assertion_message ("xamarin_bridge_mono_thread_info_current_unchecked not implemented\n");
}

MONO_API void *
xamarin_bridge_mono_threads_attach_coop (MonoDomain * domain, gpointer* dummy)
{
	LOG_CORECLR (stderr, "%s (%p, %p) => assert\n", __func__, domain, dummy);
	xamarin_assertion_message ("xamarin_bridge_mono_threads_attach_coop not implemented\n");
}

MONO_API void *
xamarin_bridge_mono_threads_detach_coop (gpointer cookie, gpointer* dummy)
{
	LOG_CORECLR (stderr, "%s (%p, %p) => assert\n", __func__, cookie, dummy);
	xamarin_assertion_message ("xamarin_bridge_mono_threads_detach_coop not implemented\n");
}

MONO_API void
xamarin_bridge_mono_install_ftnptr_eh_callback (MonoFtnPtrEHCallback callback)
{
	LOG_CORECLR (stderr, "%s (%p) => IGNORE\n", __func__, callback);
}

MONO_API void
xamarin_bridge_mono_debugger_agent_parse_options (const char * options)
{
	LOG_CORECLR (stderr, "%s (%s) => assert\n", __func__, options);
	xamarin_assertion_message ("%s not implemented\n", __func__);
}

MONO_API gboolean
xamarin_bridge_mono_debugger_agent_transport_handshake ()
{
	LOG_CORECLR (stderr, "%s () => assert\n", __func__);
	xamarin_assertion_message ("%s not implemented\n", __func__);
}

MONO_API void
xamarin_bridge_mono_debugger_agent_register_transport (DebuggerTransport * trans)
{
	LOG_CORECLR (stderr, "%s (%p) => assert\n", __func__, trans);
	xamarin_assertion_message ("%s not implemented\n", __func__);
}

typedef void (*xamarin_runtime_initialize_decl)(struct InitializationOptions* options);
void
xamarin_bridge_call_runtime_initialize (struct InitializationOptions* options, GCHandle* exception_gchandle)
{
	xamarin_load_coreclr ();

	void *del = NULL;
	int rv = coreclr_create_delegate (coreclr_handle, coreclr_domainId, PRODUCT ", Version=0.0.0.0", "ObjCRuntime.Runtime", "Initialize", &del);
	if (rv != 0)
		xamarin_assertion_message ("xamarin_bridge_call_runtime_initialize: failed to create delegate: %i\n", rv);

	xamarin_runtime_initialize_decl runtime_initialize = (xamarin_runtime_initialize_decl) del;
	runtime_initialize (options);
}

void
xamarin_bridge_register_product_assembly (GCHandle* exception_gchandle)
{
	MonoAssembly *assembly;
	assembly = xamarin_open_and_register (PRODUCT_DUAL_ASSEMBLY, exception_gchandle);
	xamarin_mono_object_release (&assembly);
}

MonoMethod *
xamarin_bridge_get_mono_method (MonoReflectionMethod *method)
{
	// MonoMethod and MonoReflectionMethod are identical in CoreCLR (both are actually MonoObjects).
	// However, we're returning a retained object, so we need to retain here.
	xamarin_mono_object_retain (method);
	LOG_CORECLR (stderr, "%s (%p): rv: %p\n", __func__, method, method);
	return method;
}

MonoType *
xamarin_get_nsnumber_type ()
{
	// xamarin_bridge_lookup_class returns a MonoClass*, and this method returns a MonoType*,
	// but they're interchangeable for CoreCLR (they're all just MonoObject*s), so this is fine.
	MonoClass *rv = xamarin_bridge_lookup_class (XamarinLookupTypes_Foundation_NSNumber);
	LOG_CORECLR (stderr, "%s () => %p\n", __func__, rv);
	return rv;
}

MonoType *
xamarin_get_nsvalue_type ()
{
	// xamarin_bridge_lookup_class returns a MonoClass*, and this method returns a MonoType*,
	// but they're interchangeable for CoreCLR (they're all just MonoObject*s), so this is fine.
	MonoClass *rv = xamarin_bridge_lookup_class (XamarinLookupTypes_Foundation_NSValue);
	LOG_CORECLR (stderr, "%s () => %p\n", __func__, rv);
	return rv;
}

void
xamarin_mono_object_retain (MonoObject *mobj)
{
	atomic_fetch_add (&mobj->reference_count, 1);
	LOG_CORECLR (stderr, "xamarin_mono_object_retain (%p) RC: %i Type Name: %s Kind: %i\n", mobj, (int) mobj->reference_count, mobj->type_name, mobj->object_kind);
}

void
xamarin_mono_object_release (MonoObject **mobj_ref)
{
	MonoObject *mobj = *mobj_ref;

	if (mobj == NULL)
		return;

	xamarin_assert (mobj != (void *) 0xdeadf00d);

	int rc = atomic_fetch_sub (&mobj->reference_count, 1) - 1;
	if (rc == 0) {
		LOG_CORECLR (stderr, "xamarin_mono_object_release (%p): will free! Type Name: %s Kind: %i\n", mobj, mobj->type_name, mobj->object_kind);
		if (mobj->gchandle != INVALID_GCHANDLE) {
			xamarin_gchandle_free (mobj->gchandle);
			mobj->gchandle = INVALID_GCHANDLE;
		}
		if (mobj->struct_value != NULL) {
			// xamarin_free (mobj->struct_value);
			mobj->struct_value = NULL;
		}
		xamarin_free (mobj); // allocated using Marshal.AllocHGlobal.
	} else {
		LOG_CORECLR (stderr, "xamarin_mono_object_release (%p): would not free, RC=%i, kind: %i\n", mobj, rc, (int) mobj->object_kind);
	}

	pthread_mutex_lock (&monoobject_dict_lock);
	CFDictionaryRemoveValue (monoobject_dict, mobj);
	pthread_mutex_unlock (&monoobject_dict_lock);

	*mobj_ref = (MonoObject *) 0xdeadf00d;
}

/* Implementation of the Mono Embedding API */

// returns a retained MonoAssembly *
MonoAssembly *
mono_assembly_open (const char * filename, MonoImageOpenStatus * status)
{
	assert (status == NULL);

	MonoAssembly *rv = xamarin_find_assembly (filename);

	LOG_CORECLR (stderr, "mono_assembly_open (%s, %p) => MonoObject=%p GCHandle=%p\n", filename, status, rv, rv->gchandle);

	return rv;
}

const char *
mono_class_get_namespace (MonoClass * klass)
{
	char *rv = xamarin_bridge_class_get_namespace (klass);

	LOG_CORECLR (stderr, "%s (%p) => %s\n", __func__, klass, rv);

	return rv;
}

const char *
mono_class_get_name (MonoClass * klass)
{
	char *rv = xamarin_bridge_class_get_name (klass);

	LOG_CORECLR (stderr, "%s (%p) => %s\n", __func__, klass, rv);

	return rv;
}

char *
mono_method_full_name (MonoMethod *method, mono_bool signature)
{
	char *rv = xamarin_bridge_get_method_full_name (method);

	LOG_CORECLR (stderr, "%s (%p, %i) => %s\n", __func__, method, signature, rv);

	return rv;
}

MonoDomain *
mono_domain_get (void)
{
	// This is not needed for CoreCLR.
	return NULL;
}

MonoType *
mono_class_get_type (MonoClass *klass)
{
	// MonoClass and MonoType are identical in CoreCLR (both are actually MonoObjects).
	// However, we're returning a retained object, so we need to retain here.
	MonoType *rv = klass;

	xamarin_mono_object_retain (rv);

	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, klass, rv);

	return rv;
}

// returns a retained MonoReflectionAssembly *
MonoReflectionAssembly *
mono_assembly_get_object (MonoDomain * domain, MonoAssembly * assembly)
{
	// MonoAssembly and MonoReflectionAssembly are identical in CoreCLR (both are actually MonoObjects).
	// However, we're returning a retained object, so we need to retain here.
	xamarin_mono_object_retain (assembly);
	LOG_CORECLR (stderr, "mono_assembly_get_object (%p, %p): rv: %p\n", domain, assembly, assembly);
	return assembly;
}

MonoReflectionMethod *
mono_method_get_object (MonoDomain *domain, MonoMethod *method, MonoClass *refclass)
{
	// MonoMethod and MonoReflectionMethod are identical in CoreCLR (both are actually MonoObjects).
	// However, we're returning a retained object, so we need to retain here.
	MonoReflectionMethod *rv = method;

	xamarin_mono_object_retain (rv);

	LOG_CORECLR (stderr, "%s (%p, %p, %p) => %p\n", __func__, domain, method, refclass, rv);

	return rv;
}

MonoType *
mono_reflection_type_get_type (MonoReflectionType *reftype)
{
	// MonoType and MonoReflectionType are identical in CoreCLR (both are actually MonoObjects).
	// However, we're returning a retained object, so we need to retain here.
	MonoType *rv = reftype;
	xamarin_mono_object_retain (rv);
	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, reftype, rv);
	return rv;
}

int
mono_jit_exec (MonoDomain * domain, MonoAssembly * assembly, int argc, const char** argv)
{
	unsigned int exitCode = 0;

	char *assemblyName = xamarin_bridge_get_assembly_name (assembly->gchandle);

	LOG_CORECLR (stderr, "mono_jit_exec (%p, %p, %i, %p) => EXECUTING %s\n", domain, assembly, argc, argv, assemblyName);
	for (int i = 0; i < argc; i++) {
		LOG_CORECLR (stderr, "    Argument #%i: %s\n", i + 1, argv [i]);
	}

	int rv = coreclr_execute_assembly (coreclr_handle, coreclr_domainId, argc, argv, assemblyName, &exitCode);

	LOG_CORECLR (stderr, "mono_jit_exec (%p, %p, %i, %p) => EXECUTING %s rv: %i exitCode: %i\n", domain, assembly, argc, argv, assemblyName, rv, exitCode);

	xamarin_free (assemblyName);

	if (rv != 0)
		xamarin_assertion_message ("mono_jit_exec failed: %i\n", rv);

	xamarin_bridge_dump_monoobjects ();

	return (int) exitCode;
}

MonoGHashTable *
mono_g_hash_table_new_type (GHashFunc hash_func, GEqualFunc key_equal_func, MonoGHashGCType type)
{
	MonoGHashTable *rv = xamarin_bridge_mono_hash_table_create (hash_func, key_equal_func, type);

	LOG_CORECLR (stderr, "%s (%p, %p, %u) => %p\n", __func__, hash_func, key_equal_func, type, rv);

	return rv;
}

gpointer
mono_g_hash_table_lookup (MonoGHashTable *hash, gconstpointer key)
{
	MonoObject *rv = xamarin_bridge_mono_hash_table_lookup (hash, key);
	LOG_CORECLR (stderr, "%s (%p, %p) => %p\n", __func__, hash, key, rv);
	return rv;
}

void
mono_g_hash_table_insert (MonoGHashTable *hash, gpointer k, gpointer v)
{
	MonoObject *obj = (MonoObject *) v;
	LOG_CORECLR (stderr, "%s (%p, %p, %p)\n", __func__, hash, k, v);
	xamarin_bridge_mono_hash_table_insert (hash, k, obj);
}

MonoClass *
mono_method_get_class (MonoMethod * method)
{
	MonoClass *rv = xamarin_bridge_get_method_declaring_type (method);
	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, method, rv);
	return rv;
}

MonoClass *
mono_object_get_class (MonoObject * obj)
{
	MonoClass *rv = xamarin_bridge_object_get_type (obj);
	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, obj, rv);
	return rv;
}

MonoObject *
mono_object_isinst (MonoObject * obj, MonoClass * klass)
{
	bool rv = xamarin_bridge_isinstance (obj, klass);
	LOG_CORECLR (stderr, "%s (%p, %p) => %i\n", __func__, obj, klass, rv);
	return rv ? obj : NULL;
}

MonoObject *
mono_value_box (MonoDomain *domain, MonoClass *klass, void *val)
{
	MonoObject *rv = xamarin_bridge_box (klass, val);
	LOG_CORECLR (stderr, "%s (%p, %p, %p) => %p\n", __func__, domain, klass, val, rv);
	return rv;
}

void *
mono_object_unbox (MonoObject *obj)
{
	void *rv = obj->struct_value;

	if (rv == NULL)
		xamarin_assertion_message ("%s (%p) => no struct value?\n", __func__);

	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, obj, rv);

	return rv;
}

// Return value: NULL, or a retained MonoObject* that must be freed with xamarin_mono_object_release.
// Returns NULL in case of exception.
MonoObject *
mono_runtime_invoke (MonoMethod * method, void * obj, void ** params, MonoObject ** exc)
{
	MonoObject *rv = NULL;
	GCHandle exception_gchandle = INVALID_GCHANDLE;

	LOG_CORECLR (stderr, "%s (%p, %p, %p, %p)\n", __func__, method, obj, params, exc);

	rv = xamarin_bridge_runtime_invoke_method (method, (MonoObject *) obj, params, &exception_gchandle);

	if (exc == NULL) {
		xamarin_handle_bridge_exception (exception_gchandle, __func__);
	} else {
		*exc = xamarin_gchandle_unwrap (exception_gchandle);
	}

	return rv;
}

MonoException *
xamarin_create_system_exception (const char *message)
{
	MonoException *rv = xamarin_bridge_create_exception (XamarinExceptionTypes_System_Exception, message);
	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, message, rv);
	return rv;
}

MonoException *
xamarin_create_system_invalid_cast_exception (const char *message)
{
	MonoException *rv = xamarin_bridge_create_exception (XamarinExceptionTypes_System_InvalidCastException, message);
	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, message, rv);
	return rv;
}

MonoException *
xamarin_create_system_entry_point_not_found_exception (const char *entrypoint)
{
	MonoException *rv = xamarin_bridge_create_exception (XamarinExceptionTypes_System_EntryPointNotFoundException, entrypoint);
	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, entrypoint, rv);
	return rv;
}

MonoObject *
xamarin_bridge_coreclr_runtime_invoke (MonoMethod * method, GCHandle obj, void ** params, MonoObject ** exc)
{
	MonoObject *mobj = xamarin_gchandle_get_target (obj);
	MonoObject *rv = mono_runtime_invoke (method, mobj, params, exc);
	xamarin_mono_object_release (&mobj);
	return rv;
}

MonoMethodSignature *
mono_method_signature (MonoMethod* method)
{
	MonoMethodSignature *rv = xamarin_bridge_method_get_signature (method);

	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, method, rv);

	return rv;
}

MonoType *
mono_signature_get_params (MonoMethodSignature* sig, void ** iter)
{
	int* p = (int *) iter;
	if (*p >= sig->parameter_count) {
		LOG_CORECLR (stderr, "%s (%p, %p => %i) => DONE\n", __func__, sig, iter, *p);
		return NULL;
	}

	MonoObject *rv = sig->parameters [*p];
	xamarin_mono_object_retain (rv);

	LOG_CORECLR (stderr, "%s (%p, %p => %i) => %p NEXT\n", __func__, sig, iter, *p, rv->gchandle);

	*p = *p + 1;

	return rv;
}

MonoType *
mono_signature_get_return_type (MonoMethodSignature* sig)
{
	MonoType *rv = sig->return_type;
	xamarin_mono_object_retain (rv);

	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, sig, rv);

	return rv;
}

MonoReflectionType *
mono_type_get_object (MonoDomain *domain, MonoType *type)
{
	MonoReflectionType *rv = type;

	xamarin_mono_object_retain (rv);

	LOG_CORECLR (stderr, "%s (%p, %p) => %p\n", __func__, domain, type, rv);

	return rv;
}

void
xamarin_bridge_free_mono_signature (MonoMethodSignature **psig)
{
	MonoMethodSignature *sig = *psig;

	if (sig == NULL)
		return;

	for (int i = 0; i < sig->parameter_count; i++) {
		xamarin_mono_object_release (&sig->parameters [i]);
	}
	xamarin_mono_object_release (&sig->return_type);

	mono_free (sig);

	*psig = NULL;
}

MonoReferenceQueue *
mono_gc_reference_queue_new (mono_reference_queue_callback callback)
{
	MonoReferenceQueue *rv = xamarin_bridge_gc_reference_queue_new (callback);

	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, callback, rv);

	return rv;
}

gboolean
mono_gc_reference_queue_add (MonoReferenceQueue *queue, MonoObject *obj, void *user_data)
{
	LOG_CORECLR (stderr, "%s (%p, %p, %p)\n", __func__, queue, obj, user_data);

	xamarin_bridge_gc_reference_queue_add (queue, obj, user_data);

	return true;
}

void
mono_free (void *ptr)
{
	free (ptr);
}

mono_bool
mono_thread_detach_if_exiting ()
{
	// Nothing to do here for CoreCLR.
	return true;
}

MonoClass *
mono_class_from_mono_type (MonoType *type)
{
	MonoClass *rv = xamarin_bridge_type_to_class (type);
	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, type, rv);
	return rv;
}

MonoClass *
mono_get_string_class ()
{
	MonoClass *rv = xamarin_bridge_lookup_class (XamarinLookupTypes_System_String);
	LOG_CORECLR (stderr, "%s () => %p.\n", __func__, rv);
	return rv;
}

mono_bool
mono_class_is_enum (MonoClass *klass)
{
	bool rv = xamarin_bridge_is_enum (klass);

	LOG_CORECLR (stderr, "%s (%p) => %i\n", __func__, klass, rv);

	return rv;
}

MonoType *
mono_class_enum_basetype (MonoClass *klass)
{
	MonoType *rv = xamarin_bridge_get_enum_basetype (klass);

	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, klass, rv);

	return rv;
}

mono_bool
mono_type_is_byref (MonoType *type)
{
	bool rv = xamarin_bridge_is_byref (type);

	LOG_CORECLR (stderr, "%s (%p) => %i\n", __func__, type, rv);

	return rv;
}

mono_bool
mono_class_is_delegate (MonoClass *klass)
{
	bool rv = xamarin_bridge_is_delegate (klass);
	LOG_CORECLR (stderr, "%s (%p) => %i\n", __func__, klass, rv);
	return rv;
}

mono_bool
mono_class_is_valuetype (MonoClass * klass)
{
	bool rv = xamarin_bridge_is_valuetype (klass);

	LOG_CORECLR (stderr, "%s (%p) => %i\n", __func__, klass, rv);

	return rv;
}

int32_t
mono_class_value_size (MonoClass *klass, uint32_t *align)
{
	int32_t rv = xamarin_bridge_sizeof (klass);

	LOG_CORECLR (stderr, "%s (%p, %p) => %i\n", __func__, klass, align, rv);

	return rv;
}

gboolean
mono_class_is_nullable (MonoClass * klass)
{
	bool rv = xamarin_bridge_is_nullable (klass);

	LOG_CORECLR (stderr, "%s (%p) => %i\n", __func__, klass, rv);

	return rv;
}

MonoClass *
mono_class_get_element_class (MonoClass *klass)
{
	MonoClass *rv = xamarin_bridge_get_element_class (klass);
	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, klass, rv);
	return rv;
}

MonoClass *
mono_class_get_nullable_param (MonoClass * klass)
{
	MonoClass *rv = xamarin_bridge_get_nullable_element_type (klass);
	LOG_CORECLR (stderr, "%s (%p) => %p\n", __func__, klass, rv);
	return rv;
}

bool
xamarin_is_class_nsobject (MonoClass *cls)
{
	return xamarin_bridge_is_class_of_type (cls, XamarinLookupTypes_Foundation_NSObject);
}

bool
xamarin_is_class_inativeobject (MonoClass *cls)
{
	return xamarin_bridge_is_class_of_type (cls, XamarinLookupTypes_ObjCRuntime_INativeObject);
}

bool
xamarin_is_class_array (MonoClass *cls)
{
	return xamarin_bridge_is_class_of_type (cls, XamarinLookupTypes_System_Array);
}

bool
xamarin_is_class_nsnumber (MonoClass *cls)
{
	return xamarin_bridge_is_class_of_type (cls, XamarinLookupTypes_Foundation_NSNumber);
}

bool
xamarin_is_class_nsvalue (MonoClass *cls)
{
	return xamarin_bridge_is_class_of_type (cls, XamarinLookupTypes_Foundation_NSValue);
}

bool
xamarin_is_class_nsstring (MonoClass *cls)
{
	return xamarin_bridge_is_class_of_type (cls, XamarinLookupTypes_Foundation_NSString);
}

bool
xamarin_is_class_intptr (MonoClass *cls)
{
	return xamarin_bridge_is_class_of_type (cls, XamarinLookupTypes_System_IntPtr);
}

bool
xamarin_is_class_string (MonoClass *cls)
{
	return xamarin_bridge_is_class_of_type (cls, XamarinLookupTypes_System_String);
}

MonoArray *
mono_array_new (MonoDomain *domain, MonoClass *eclass, uintptr_t n)
{
	MonoArray *rv = xamarin_bridge_create_array (eclass, n);
	LOG_CORECLR (stderr, "%s (%p, %p, %" PRIdPTR ") => %p\n", __func__, domain, eclass, n, rv);
	return rv;
}

uintptr_t
mono_array_length (MonoArray *array)
{
	uintptr_t rv = (uintptr_t) xamarin_bridge_get_array_length (array);
	LOG_CORECLR (stderr, "%s (%p) => %llu\n", __func__, array, (uint64_t) rv);
	return rv;
}

char *
mono_string_to_utf8 (MonoString *string_obj)
{
	char *rv = xamarin_bridge_string_to_utf8 (string_obj);

	LOG_CORECLR (stderr, "%s (%p) => %s\n", __func__, string_obj, rv);

	return rv;
}

MonoString *
mono_string_new (MonoDomain *domain, const char *text)
{
	MonoString *rv = xamarin_bridge_new_string (text);

	LOG_CORECLR (stderr, "%s (%p, %s) => %p\n", __func__, domain, text, rv);

	return rv;
}

#endif // CORECLR_RUNTIME
