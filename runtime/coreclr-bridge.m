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

static bool reference_tracking_begun = false;

void
xamarin_coreclr_reference_tracking_begin_end_callback ()
{
	LOG_CORECLR (stderr, "LOG: %s () reference_tracking_begun: %i\n", __func__, reference_tracking_begun);
	if (reference_tracking_begun) {
		xamarin_gc_event (MONO_GC_EVENT_PRE_STOP_WORLD);
	} else {
		xamarin_gc_event (MONO_GC_EVENT_POST_START_WORLD);
	}
	reference_tracking_begun = !reference_tracking_begun;
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
	xamarin_process_managed_exception_gchandle (exception_gchandle);

	xamarin_assertion_message ("Failed to process managed exception.");
}

void
xamarin_enable_new_refcount ()
{
	// Nothing to do here.
}

GCHandle
xamarin_get_mono_method_gchandle (MonoMethod *method)
{
	GCHandle rv = method->gchandle_tmp;
	if (rv == INVALID_GCHANDLE) {
		rv = xamarin_bridge_find_method (method->klass->gchandle, method->name, method->param_count);
		// FIXME: thread safety
		method->gchandle_tmp = rv;
	}
	return rv;
}

MonoMethod *
xamarin_bridge_get_mono_method (MonoReflectionMethod *reflection_method)
{
	MonoMethod *rv = (MonoMethod *) calloc (1, sizeof (MonoMethod));
	rv->gchandle_tmp = xamarin_gchandle_duplicate (reflection_method->gchandle, XamarinGCHandleTypeNormal);
	rv->name = xamarin_bridge_get_method_name (reflection_method->gchandle);
	GCHandle klass_handle = xamarin_bridge_get_method_declaring_type (reflection_method->gchandle);
	rv->klass = xamarin_find_mono_class (klass_handle);
	xamarin_gchandle_free (klass_handle);

	LOG_CORECLR (stderr, "xamarin_bridge_get_mono_method (%p = %p) => %p = %s.%s = %p\n", reflection_method, reflection_method->gchandle, rv, rv->klass->fullname, rv->name, rv->gchandle_tmp);

	return rv;
}

void
xamarin_create_managed_ref_coreclr (id self, GCHandle managed_object, bool retain, bool user_type)
{
	MonoObject *mobj = xamarin_gchandle_get_target (managed_object);
	xamarin_create_managed_ref (self, mobj, retain, user_type);
	xamarin_mono_object_release (&mobj);
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
			fprintf (stderr, "Object %i/%i %p Kind: %i RC: %i\n", i + 1, (int) length, obj, obj->object_kind, (int) obj->reference_count);
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

static Boolean
hash_str_equal (const void *a, const void *b)
{
	return strcmp ((const char *) a, (const char *) b) == 0;
}

static CFHashCode
hash_str_hash (const void *a)
{
	const char *str = (const char *) a;
    CFHashCode hash = 5381;
    int c;

    while ((c = *str++))
        hash = ((hash << 5) + hash) + (unsigned long) c; /* hash * 33 + c */

	// LOG_CORECLR (stderr, "hash_str_hash ('%s') => %lu\n", (const char *) a, hash);

    return hash;
}

static CFMutableDictionaryRef mono_class_hash_table = NULL;
MonoClass *
xamarin_find_mono_class (GCHandle gchandle, const char *name_space, const char *name)
{
	MonoClass *entry = NULL;
	char *fullname = NULL;

	if (name_space == NULL && name == NULL) {
		if (gchandle == INVALID_GCHANDLE)
			xamarin_assertion_message ("xamarin_find_mono_class called with no valid input");
		fullname = xamarin_bridge_get_type_fullname (gchandle, NULL);
	} else if (name_space == NULL) {
		fullname = xamarin_strdup_printf ("%s", name);
	} else {
		fullname = xamarin_strdup_printf ("%s.%s");
	}

	if (mono_class_hash_table == NULL) {
		CFDictionaryKeyCallBacks key_callbacks = { 0 };
		key_callbacks.equal = hash_str_equal;
		key_callbacks.hash = hash_str_hash;
		mono_class_hash_table = CFDictionaryCreateMutable (kCFAllocatorDefault, 0, &key_callbacks, NULL);
	} else {
		entry = (MonoClass *) CFDictionaryGetValue (mono_class_hash_table, fullname);
	}

	if (entry == NULL) {
		GCHandle class_gchandle = gchandle;
		if (class_gchandle == INVALID_GCHANDLE) {
			if (xamarin_get_initialization_finished ()) {
				class_gchandle = xamarin_bridge_get_type (fullname, NULL);
			}
		} else {
			class_gchandle = xamarin_bridge_create_gchandle (gchandle, XamarinGCHandleTypeNormal, NULL);
		}
		entry = (MonoClass *) calloc (1, sizeof (MonoClass));
		entry->gchandle = class_gchandle;
		entry->fullname = strdup (fullname);
		entry->name_space = name_space == NULL ? NULL : strdup (name_space);
		entry->name = name == NULL ? NULL : strdup (name);
		CFDictionarySetValue (mono_class_hash_table, entry->fullname, entry);
		LOG_CORECLR (stderr, "xamarin_find_mono_class (%p, %s, %s) => added %p = %s (GCHandle: %p) with key %s\n", gchandle, name_space, name, entry, entry->fullname, entry->gchandle, fullname);
	} else {
		LOG_CORECLR (stderr, "xamarin_find_mono_class (%p, %s, %s) => found %p = %s (GCHandle: %p) for key %s\n", gchandle, name_space, name, entry, entry->fullname, entry->gchandle, fullname);
	}

	if (xamarin_get_initialization_finished ()) {
		if (entry->gchandle == INVALID_GCHANDLE) {
			entry->gchandle = xamarin_bridge_get_type (fullname);
			LOG_CORECLR (stderr, "xamarin_find_mono_class (%p, %s, %s) => got GCHandle %p for %s\n", gchandle, name_space, name, entry->gchandle, entry->fullname);
		}
		if (entry->name_space == NULL && entry->name == NULL) {
			xamarin_bridge_get_name_and_namespace (entry->gchandle, &entry->name_space, &entry->name, NULL);
			LOG_CORECLR (stderr, "xamarin_find_mono_class (%p, %s, %s) => got Namespace=%s and Name=%s for FullName=%s and GCHandle=%p\n", gchandle, name_space, name, entry->name_space, entry->name, entry->fullname, entry->gchandle);
		}
	}

	free (fullname);

	return entry;
}

MonoType *
xamarin_create_mono_type (const char *name, GCHandle gchandle, GCHandle* exception_gchandle)
{
	char *type_name;
	if (name == NULL) {
		type_name = xamarin_bridge_get_type_fullname (gchandle, exception_gchandle);
		if (exception_gchandle != NULL && *exception_gchandle != INVALID_GCHANDLE)
			return NULL;
	} else {
		type_name = strdup (name);
	}

	MonoType *rv = (MonoType *) calloc (1, sizeof (MonoType));
	rv->name = type_name;
	rv->fullname = type_name ? strdup (type_name) : NULL;
	rv->gchandle = gchandle;

	return rv;
}

MONO_API gchar *
xamarin_bridge_mono_path_resolve_symlinks (const char * path)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_path_resolve_symlinks (%s) => %s\n", path, path);
	return (gchar *) strdup (path);
}

MONO_API gboolean
xamarin_bridge_mini_parse_debug_option (const char * option)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mini_parse_debug_option (%s) => IGNORED\n", option);
	return true;
}

MONO_API void
xamarin_bridge_mono_free (void * ptr)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_free (%p) => FREED\n", ptr);
	free (ptr);
}

MONO_API void
xamarin_bridge_mono_debug_init (MonoDebugFormat format)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_debug_init (%p)\n", (void *) format);
}

MONO_API void
xamarin_bridge_mono_gc_collect (int generation)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_gc_collect (%i)\n", generation);
}

MONO_API MonoClass *
xamarin_bridge_mono_class_from_name (MonoImage * image, const char * name_space, const char * name)
{
	MonoClass *rv = xamarin_find_mono_class (INVALID_GCHANDLE, name_space, name);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_from_name (%p, %s, %s) => %p\n", image, name_space, name, rv);
	return rv;
}

MONO_API MonoMethod *
xamarin_bridge_mono_class_get_method_from_name (MonoClass * klass, const char * name, int param_count)
{
	xamarin_assert (klass != NULL);
	MonoMethod *rv = (MonoMethod *) calloc (1, sizeof (MonoMethod));
	rv->klass = klass;
	rv->name = strdup (name);
	rv->param_count = param_count;

	if (xamarin_get_initialization_finished ())
		rv->gchandle_tmp = xamarin_bridge_find_method (rv->klass->gchandle, rv->name, rv->param_count);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_get_method_from_name (%p, %s, %i) => %p\n", klass, name, param_count, rv);
	return rv;
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
xamarin_bridge_mono_class_from_mono_type (MonoType * type)
{
	GCHandle type_gchandle;

	if (xamarin_bridge_mono_type_is_byref (type)) {
		type_gchandle = xamarin_bridge_type_remove_byref (type->gchandle);
	} else {
		type_gchandle = xamarin_bridge_create_gchandle (type->gchandle, XamarinGCHandleTypeNormal);
	}

	MonoClass *rv = xamarin_find_mono_class (type_gchandle /* get name[space] from type?  type->name */);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_from_mono_type (%p = %s) => %p = %s\n", type, type->name, rv, rv->fullname);
	return rv;
}

MONO_API mono_bool
xamarin_bridge_mono_class_is_delegate (MonoClass * klass)
{
	bool rv = xamarin_bridge_is_delegate (klass->gchandle);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_is_delegate (%p = %s) => %i\n", klass, klass->fullname, rv);
	return rv;
}

MONO_API MonoClass *
xamarin_bridge_mono_class_get_element_class (MonoClass * klass)
{
	// FIXME
	klass = xamarin_find_mono_class (klass->gchandle, klass->name_space, klass->name);

	GCHandle element_type = xamarin_bridge_get_element_class (klass->gchandle);
	MonoClass *rv = xamarin_find_mono_class (element_type);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_get_element_class (%p = %s) => %p = %s = %p\n", klass, klass->fullname, rv, rv->fullname, rv->gchandle);
	return rv;
}

MONO_API const char *
xamarin_bridge_mono_class_get_namespace (MonoClass * klass)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_get_namespace (%p => %s) => %s\n", klass, klass->fullname, klass->name_space);
	return klass->name_space;
}

MONO_API const char *
xamarin_bridge_mono_class_get_name (MonoClass * klass)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_get_name (%p => %s) => %s\n", klass, klass->fullname, klass->name);
	return klass->name;
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
	// FIXME
	klass = xamarin_find_mono_class (klass->gchandle, klass->name_space, klass->name);
	klassc = xamarin_find_mono_class (klassc->gchandle, klassc->name_space, klassc->name);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_is_subclass_of (%p = %s = %p, %p = %s = %p, %i)\n", klass, klass ? klass->fullname : "NULL", klass->gchandle, klassc, klassc ? klassc->fullname : "NULL", klassc->gchandle, check_interfaces);

	bool rv = xamarin_bridge_is_subclass_of (klass->gchandle, klassc->gchandle, check_interfaces);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_is_subclass_of (%p = %s, %p = %s, %i) => %i\n", klass, klass->fullname, klassc, klassc->fullname, check_interfaces, rv);

	return rv;
}

MONO_API mono_bool
xamarin_bridge_mono_class_is_valuetype (MonoClass * klass)
{
	bool rv = xamarin_bridge_is_valuetype (klass->gchandle);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_is_valuetype (%p = %s) => %i\n", klass, klass->fullname, rv);
	return rv;
}

MONO_API mono_bool
xamarin_bridge_mono_class_is_enum (MonoClass * klass)
{
	bool rv = xamarin_bridge_is_enum (klass->gchandle);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_is_enum (%p = %s) => %i\n", klass, klass->fullname, rv);
	return rv;
}

MONO_API MonoType *
xamarin_bridge_mono_class_enum_basetype (MonoClass * klass)
{
	GCHandle handle = xamarin_bridge_get_enum_basetype (klass->gchandle);
	MonoType *rv = xamarin_create_mono_type (NULL, handle);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_enum_basetype (%p = %s) => %p = %s\n", klass, klass->fullname, rv, rv->name);
	return rv;
}

MONO_API int32_t
xamarin_bridge_mono_class_value_size (MonoClass * klass, uint32_t * align)
{
	if (align)
		xamarin_assertion_message ("xamarin_bridge_mono_class_value_size (..., align) not implemented\n");

	int32_t rv = xamarin_bridge_sizeof (klass->gchandle);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_value_size (%p = %s, %p) => %i\n", klass, klass->fullname, align, rv);

	return rv;
}

MONO_API MonoType *
xamarin_bridge_mono_class_get_type (MonoClass * klass)
{
	MonoType *rv = xamarin_create_mono_type (NULL, klass->gchandle);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_get_type (%p) => %p = %p\n", klass, rv, rv->gchandle);
	return rv;
}

MONO_API gboolean
xamarin_bridge_mono_class_is_nullable (MonoClass * klass)
{
	bool rv = xamarin_bridge_is_nullable (klass->gchandle);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_is_nullable (%p = %s) => %i\n", klass, klass->fullname, rv);
	return rv;
}

MONO_API MonoClass *
xamarin_bridge_mono_class_get_nullable_param (MonoClass * klass)
{
	GCHandle gchandle = xamarin_bridge_get_nullable_element_type (klass->gchandle);
	MonoClass *rv = xamarin_find_mono_class (gchandle, NULL, NULL);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_class_get_nullable_param (%p) => %p = %s = %p\n", klass, rv, rv->fullname, rv->gchandle);
	return rv;
}

MONO_API char *
xamarin_bridge_mono_method_full_name (MonoMethod * method, mono_bool signature)
{
	char *rv = strdup (method->name);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_method_full_name (%p, %i) => %s\n", method, signature, rv);
	return rv;

}

// Return value: NULL, or a retained MonoObject* that must be freed with xamarin_mono_object_release.
// Returns NULL in case of exception.
MONO_API MonoObject *
xamarin_bridge_mono_runtime_invoke (MonoMethod * method, void * obj, void ** params, MonoObject ** exc)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_runtime_invoke (%p, %p, %p, %p) => %s.%s\n", method, obj, params, exc, method->klass->fullname, method->name);

	MonoObject *instance = (MonoObject *) obj;
	return xamarin_bridge_coreclr_runtime_invoke (method, instance != NULL ? instance->gchandle : INVALID_GCHANDLE, params, exc);
}

MonoObject *
xamarin_bridge_coreclr_runtime_invoke (MonoMethod * method, GCHandle obj, void ** params, MonoObject ** exc)
{
	MonoObject * returnValue = NULL;
	GCHandle exception_gchandle = INVALID_GCHANDLE;
	returnValue = xamarin_bridge_runtime_invoke_method (xamarin_get_mono_method_gchandle (method), obj, params, &exception_gchandle);
	xamarin_handle_bridge_exception (exception_gchandle, __func__);
	return returnValue;
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

MONO_API MonoArray *
xamarin_bridge_mono_array_new (MonoDomain * domain, MonoClass * eclass, uintptr_t n)
{
	MonoArray *rv = xamarin_bridge_create_array (eclass->gchandle, n);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_array_new (%p, %p, %" PRIdPTR ") => %p = %p\n", domain, eclass, n, rv, rv->gchandle);
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

// Return value: NULL, or allocated UTF8 string which the caller must free with xamarin_free.
MONO_API char *
xamarin_bridge_mono_string_to_utf8 (MonoString * string_obj)
{
	char * rv = NULL;

	xamarin_assert (string_obj->object_kind == MonoObjectType_MonoString);

	if (string_obj != NULL)
		rv = xamarin_bridge_string_to_utf8 (string_obj->gchandle);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_string_to_utf8 (%p = %p) => %s\n", string_obj, string_obj->gchandle, rv);

	return rv;
}

// Return value: NULL, or a retained MonoObject* which the caller must free with xamarin_mono_object_release
MONO_API MonoObject *
xamarin_bridge_mono_object_new (MonoDomain * domain, MonoClass * klass)
{
	MonoObject *rv = xamarin_bridge_create_object (klass->gchandle);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_object_new (%p, %p) => %p\n", domain, klass, rv);
	return rv;
}

MONO_API uintptr_t
xamarin_bridge_mono_array_length (MonoArray * array)
{
	xamarin_assert (array->object_kind == MonoObjectType_MonoArray);

	uintptr_t rv = (uintptr_t) xamarin_bridge_get_array_length (array->gchandle);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_array_length (%p = %p) => %llu\n", array, array->gchandle, (uint64_t) rv);
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
	LOG_CORECLR (stderr, "xamarin_bridge_mono_object_isinst (%p => %s, %p => %s) => %i\n", obj, obj->type_name, klass, klass->fullname, rv);
	return rv;
}

MONO_API MonoClass *
xamarin_bridge_mono_object_get_class (MonoObject * obj)
{
	GCHandle type_gchandle = xamarin_bridge_object_get_type (obj->gchandle);

	MonoClass *rv = xamarin_find_mono_class (type_gchandle);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_object_get_class (%p) => %p = %s\n", obj, rv, rv->fullname);

	return rv;
}

MonoClass *
xamarin_bridge_coreclr_gchandle_get_class (GCHandle obj)
{
	GCHandle type_gchandle = xamarin_bridge_object_get_type (obj);

	MonoClass *rv = xamarin_find_mono_class (type_gchandle);

	LOG_CORECLR (stderr, "xamarin_bridge_coreclr_gchandle_get_class (%p) => %p = %s\n", obj, rv, rv->fullname);

	return rv;
}

MONO_API MonoMethod *
xamarin_bridge_mono_object_get_virtual_method (MonoObject * obj, MonoMethod * method)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_object_get_virtual_method (%p, %p) => assert\n", obj, method);
	xamarin_assertion_message ("xamarin_bridge_mono_object_get_virtual_method not implemented\n");
}

MONO_API void
xamarin_bridge_mono_field_get_value (MonoObject * obj, MonoClassField * field, void * value)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_field_get_value (%p, %p, %p) => assert\n", obj, field, value);
	xamarin_assertion_message ("xamarin_bridge_mono_field_get_value not implemented\n");
}

// Return value: a retained MonoObject*, which the caller must release with xamarin_mono_object_release.
MONO_API MonoObject *
xamarin_bridge_mono_value_box (MonoDomain * domain, MonoClass * klass, void * val)
{
	MonoObject *rv = xamarin_bridge_box (klass->gchandle, val);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_value_box (%p, %p = %s, %p) => %p = %p = %s\n", domain, klass, klass->fullname, val, rv, rv->gchandle, rv->type_name);
	return rv;
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
xamarin_bridge_mono_runtime_set_pending_exception (MonoException * exc, mono_bool overwrite)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_runtime_set_pending_exception (%p, %i) => IGNORE NEEDS TO FIX\n", exc, overwrite);
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
	LOG_CORECLR (stderr, "xamarin_bridge_mono_dangerous_add_raw_internal_call (%s, %s) => IGNORE\n", name, method);
}

MONO_API MonoMethodSignature *
xamarin_bridge_mono_method_signature (MonoMethod * method)
{
	MonoMethodSignature *rv = (MonoMethodSignature *) calloc (1, sizeof (MonoMethodSignature));
	LOG_CORECLR (stderr, "xamarin_bridge_mono_method_signature (%p => %p) => %p\n", method, xamarin_get_mono_method_gchandle (method), rv);
	rv->method = method;
	rv->parameters = (struct __MethodParameter *) xamarin_bridge_method_get_signature (xamarin_get_mono_method_gchandle (method), &rv->parameter_count);
	return rv;
}

MONO_API MonoClass *
xamarin_bridge_mono_method_get_class (MonoMethod * method)
{
	xamarin_assert (method != NULL);
	xamarin_assert (method->klass != NULL);
	// if (method->klass == NULL) {
	// 	GCHandle declaring_type_gchandle = xamarin_bridge_get_method_declaring_type (method->gchandle_tmp);
	// 	method->klass = xamarin_find_mono_class (declaring_type_gchandle);
	// }

	LOG_CORECLR (stderr, "xamarin_bridge_mono_method_get_class (%p) => %p = %s\n", method, method->klass->gchandle, method->klass->name);

	return method->klass;
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
	MonoClass *rv = xamarin_find_mono_class (INVALID_GCHANDLE, "System", "IntPtr");
	LOG_CORECLR (stderr, "xamarin_bridge_mono_get_intptr_class () => %p = %s\n", rv, rv->name);
	return rv;
}

MONO_API MonoClass *
xamarin_bridge_mono_get_string_class (void)
{
	MonoClass *rv = xamarin_find_mono_class (INVALID_GCHANDLE, "System", "String");
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
	MonoClass *rv = xamarin_find_mono_class (INVALID_GCHANDLE, "System", "Array");
	LOG_CORECLR (stderr, "xamarin_bridge_mono_get_array_class () => %p = %s\n", rv, rv->name);
	return rv;
}

MONO_API MonoClass *
xamarin_bridge_mono_get_exception_class (void)
{
	MonoClass *rv = xamarin_find_mono_class (INVALID_GCHANDLE, "System", "Exception");
	LOG_CORECLR (stderr, "xamarin_bridge_mono_get_exception_class () => %p = %s\n", rv, rv->name);
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
	MonoReflectionMethod *rv = (MonoReflectionMethod *) xamarin_gchandle_get_target (xamarin_get_mono_method_gchandle (method));

	LOG_CORECLR (stderr, "xamarin_bridge_mono_method_get_object (%p, %p, %p) => %p = %p\n", domain, method, refclass, rv, rv->gchandle);

	return rv;
}

MONO_API MonoReflectionType *
xamarin_bridge_mono_type_get_object (MonoDomain * domain, MonoType * type)
{
	MonoReflectionType *rv = (MonoReflectionType *) calloc (1, sizeof (MonoReflectionType));
	rv->type = type;
	rv->gchandle = xamarin_bridge_create_gchandle (type->gchandle, XamarinGCHandleTypeNormal);
	rv->object_kind = MonoObjectType_MonoReflectionType;

	LOG_CORECLR (stderr, "xamarin_bridge_mono_type_get_object (%p, %p = %s) => %p = %p\n", domain, type, type->name, rv, rv->gchandle);

	return rv;
}

void
xamarin_install_nsautoreleasepool_hooks ()
{
	// https://github.com/xamarin/xamarin-macios/issues/11256
	fprintf (stderr, "TODO: add support for wrapping all threads with NSAutoreleasePools.\n");
}

MONO_API MonoType *
xamarin_bridge_mono_reflection_type_get_type (MonoReflectionType * reftype)
{
	MonoType *rv = reftype->type;
	LOG_CORECLR (stderr, "xamarin_bridge_mono_reflection_type_get_type (%p = %s) => %p = %s\n", reftype, reftype->name, rv, rv->name);
	return rv;
}

MONO_API MonoType *
xamarin_bridge_mono_signature_get_params (MonoMethodSignature * sig, void ** iter)
{
	int* p = (int *) iter;
	if (*p >= sig->parameter_count) {
		LOG_CORECLR (stderr, "xamarin_bridge_mono_signature_get_params (%p => %s, %p => %i) => DONE\n", sig, sig->method->name, iter, *p);
		return NULL;
	}

	MonoType *rv = xamarin_create_mono_type (sig->parameters [*p].type_name, sig->parameters [*p].type_gchandle);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_signature_get_params (%p => %s, %p => %i) => %s %p NEXT\n", sig, sig->method->name, iter, *p, rv->name, rv->gchandle);

	*p = *p + 1;

	return rv;
}

MONO_API mono_bool
xamarin_bridge_mono_type_is_byref (MonoType * type)
{
	bool rv = xamarin_bridge_is_byref (type->gchandle);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_type_is_byref (%p = %s) => %i\n", type, type->name, rv);

	return rv;
}

MONO_API MonoType *
xamarin_bridge_mono_signature_get_return_type (MonoMethodSignature * sig)
{
	GCHandle return_type_gchandle = xamarin_bridge_get_method_returntype (xamarin_get_mono_method_gchandle (sig->method));
	MonoType *rv = xamarin_create_mono_type (NULL, return_type_gchandle);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_signature_get_return_type (%p) => %p = %s\n", sig, rv->gchandle, rv->name);

	return rv;
}

MONO_API int
xamarin_bridge_mono_type_get_type (MonoType * type)
{
	if (0 == (int) type->type) {
		if (type->fullname == NULL) {
			type->type = MONO_TYPE_VOID;
		} else if (!strcmp (type->fullname, "System.Byte")) {
			type->type = MONO_TYPE_U1;
		} else if (!strcmp (type->fullname, "System.SByte")) {
			type->type = MONO_TYPE_I1;
		} else if (!strcmp (type->fullname, "System.UInt16")) {
			type->type = MONO_TYPE_U2;
		} else if (!strcmp (type->fullname, "System.Int16")) {
			type->type = MONO_TYPE_I2;
		} else if (!strcmp (type->fullname, "System.UInt32")) {
			type->type = MONO_TYPE_U4;
		} else if (!strcmp (type->fullname, "System.Int32")) {
			type->type = MONO_TYPE_I4;
		} else if (!strcmp (type->fullname, "System.UInt64")) {
			type->type = MONO_TYPE_U8;
		} else if (!strcmp (type->fullname, "System.Int64")) {
			type->type = MONO_TYPE_I8;
		} else if (!strcmp (type->fullname, "System.Single")) {
			type->type = MONO_TYPE_R4;
		} else if (!strcmp (type->fullname, "System.Double")) {
			type->type = MONO_TYPE_R8;
		} else if (!strcmp (type->fullname, "System.Boolean")) {
			type->type = MONO_TYPE_BOOLEAN;
		} else if (!strcmp (type->fullname, "System.String")) {
			type->type = MONO_TYPE_STRING;
		} else {
			type->type = MONO_TYPE_UNKNOWN;
		}
	}

	MonoTypeEnum rv =type->type;
	LOG_CORECLR (stderr, "xamarin_bridge_mono_type_get_type (%p = %s) => %i\n", type, type->fullname, (int) rv);
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

MONO_API MonoGHashTable *
xamarin_bridge_mono_g_hash_table_new_type (GHashFunc hash_func, GEqualFunc key_equal_func, MonoGHashGCType type)
{
	MonoGHashTable *rv;

	rv = (MonoGHashTable *) calloc (1, sizeof (MonoGHashTable));
	rv->gchandle = xamarin_bridge_mono_hash_table_create ((void *) hash_func, (void *) key_equal_func, (int) type);

	LOG_CORECLR (stderr, "xamarin_bridge_mono_g_hash_table_new_type (%p, %p, %u) => %p = %p\n", hash_func, key_equal_func, type, rv, rv->gchandle);

	return rv;
}

// Return value: a retained MonoObject*, caller must release with xamarin_mono_object_release
MONO_API gpointer
xamarin_bridge_mono_g_hash_table_lookup (MonoGHashTable * hash, gconstpointer key)
{
	MonoObject *rv = xamarin_bridge_mono_hash_table_lookup (hash->gchandle, (void *) key);
	LOG_CORECLR (stderr, "xamarin_bridge_mono_g_hash_table_lookup (%p = %p, %p) => %p\n", hash, hash->gchandle, key, rv);
	return rv;
}

MONO_API void
xamarin_bridge_mono_g_hash_table_insert (MonoGHashTable * hash, gpointer k, gpointer v)
{
	MonoObject *obj = (MonoObject *) v;
	LOG_CORECLR (stderr, "xamarin_bridge_mono_g_hash_table_insert (%p = %p, %p, %p = %p)\n", hash, hash->gchandle, k, v, obj->gchandle);
	xamarin_bridge_mono_hash_table_insert (hash->gchandle, k, obj->gchandle);
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

MONO_API MonoReferenceQueue *
xamarin_bridge_mono_gc_reference_queue_new (mono_reference_queue_callback callback)
{
	GCHandle queue_handle;

	queue_handle = xamarin_bridge_gc_reference_queue_create ((void *) callback);

	MonoReferenceQueue *rv = (MonoReferenceQueue *) calloc (1, sizeof (MonoReferenceQueue));
	rv->gchandle = queue_handle;

	LOG_CORECLR (stderr, "xamarin_bridge_mono_gc_reference_queue_new (%p) => %p = %p\n", callback, rv, rv->gchandle);

	return rv;
}

MONO_API void
xamarin_bridge_mono_gc_reference_queue_free (MonoReferenceQueue * queue)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_gc_reference_queue_free (%p) => assert\n", queue);
	xamarin_assertion_message ("xamarin_bridge_mono_gc_reference_queue_free not implemented\n");
}

MONO_API gboolean
xamarin_bridge_mono_gc_reference_queue_add (MonoReferenceQueue * queue, MonoObject * obj, void * user_data)
{
	LOG_CORECLR (stderr, "xamarin_bridge_mono_gc_reference_queue_add (%p = %p, %p = %p, %p)\n", queue, queue->gchandle, obj, obj->gchandle, user_data);

	xamarin_bridge_gc_reference_queue_add (queue->gchandle, obj->gchandle, user_data);

	return true;
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

static MonoClass *
get_class (const char *nspace, const char *name)
{
	MonoClass *rv = xamarin_find_mono_class (INVALID_GCHANDLE, nspace, name);
	if (rv == NULL)
		xamarin_assertion_message ("Internal consistency error, please file a bug (https://github.com/xamarin/xamarin-macios/issues/new). Additional data: can't get the %s.%s class because it's been linked away.\n", nspace, name);
	return rv;
}

MonoClass *
xamarin_get_nsnumber_class ()
{
	static MonoClass *klass = NULL;
	if (klass == NULL)
		klass = get_class ("Foundation", "NSNumber");
	return klass;
}

MonoClass *
xamarin_get_nsvalue_class ()
{
	static MonoClass *klass = NULL;
	if (klass == NULL)
		klass = get_class ("Foundation", "NSValue");
	return klass;
}

MonoClass *
xamarin_get_inativeobject_class ()
{
	static MonoClass *klass = NULL;
	if (klass == NULL)
		klass = get_class ("ObjCRuntime", "INativeObject");
	return klass;
}

MonoClass *
xamarin_get_nsobject_class ()
{
	static MonoClass *klass = NULL;
	if (klass == NULL)
		klass = get_class ("Foundation", "NSObject");
	return klass;
}

MonoClass *
xamarin_get_nsstring_class ()
{
	static MonoClass *klass = NULL;
	if (klass == NULL)
		klass = get_class ("Foundation", "NSObject");
	return klass;
}

MonoClass *
xamarin_get_runtime_class ()
{
	static MonoClass *klass = NULL;
	if (klass == NULL)
		klass = get_class ("ObjCRuntime", "Runtime");
	return klass;
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

	xamarin_mono_object_release_unsafe (mobj);

	*mobj_ref = NULL;
}

void
xamarin_mono_object_release_unsafe (MonoObject *mobj)
{
	if (mobj == NULL)
		return;

	int rc = atomic_fetch_sub (&mobj->reference_count, 1) - 1;
	if (rc == 0) {
		LOG_CORECLR (stderr, "xamarin_mono_object_release (%p): will free! Type Name: %s Kind: %i\n", mobj, mobj->type_name, mobj->object_kind);
		if (mobj->gchandle != INVALID_GCHANDLE) {
			xamarin_gchandle_free (mobj->gchandle);
			mobj->gchandle = INVALID_GCHANDLE;
		}
		if (mobj->type_name != NULL) {
			xamarin_free (mobj->type_name);
			mobj->type_name = NULL;
		}
		if (mobj->struct_value != NULL) {
			xamarin_free (mobj->struct_value);
			mobj->struct_value = NULL;
		}
		switch (mobj->object_kind) {
		case MonoObjectType_Object:
			break;
		case MonoObjectType_MonoReflectionMethod: {
			MonoReflectionMethod *mrm = (MonoReflectionMethod *) mobj;
			if (mrm->name != NULL) {
				xamarin_free (mrm->name);
				mrm->name = NULL;
			}
			break;
		}
		case MonoObjectType_MonoReflectionType: {
			MonoReflectionType *mrt = (MonoReflectionType *) mobj;
			if (mrt->name != NULL) {
				xamarin_free (mrt->name);
				mrt->name = NULL;
			}
			break;
		}
		case MonoObjectType_MonoArray: {
			MonoArray *array = (MonoArray *) mobj;
			if (array->data != NULL) {
				xamarin_free (array->data);
				array->data = NULL;
			}
			break;
		}
		case MonoObjectType_MonoString: {
			// Nothing to do here
			break;
		}
		default:
			fprintf (stderr, "xamarin_mono_object_release (%p): unknown kind: %i\n", mobj, mobj->object_kind);
			break;
		}

		xamarin_free (mobj); // allocated using Marshal.AllocHGlobal.
	} else {
		LOG_CORECLR (stderr, "xamarin_mono_object_release (%p): would not free, RC=%i, kind: %i\n", mobj, rc, (int) mobj->object_kind);
	}

	pthread_mutex_lock (&monoobject_dict_lock);
	CFDictionaryRemoveValue (monoobject_dict, mobj);
	pthread_mutex_unlock (&monoobject_dict_lock);
}

void
xamarin_mono_object_release (MonoReflectionMethod **mobj)
{
	xamarin_mono_object_release ((MonoObject **) *mobj);
}

void
xamarin_mono_object_release (MonoReflectionType **mobj)
{
	xamarin_mono_object_release ((MonoObject **) *mobj);
}

void
xamarin_mono_object_release (MonoArray **mobj)
{
	xamarin_mono_object_release ((MonoObject **) *mobj);
}

void
xamarin_mono_object_release (MonoString **mobj)
{
	xamarin_mono_object_release ((MonoObject **) *mobj);
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

MonoDomain *
mono_domain_get (void)
{
	// This is not needed for CoreCLR.
	return NULL;
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

#endif // CORECLR_RUNTIME
