
/* Support for using CoreCLR */

#if defined (CORECLR_RUNTIME)

#ifndef __CORECLR_BRIDGE__
#define __CORECLR_BRIDGE__

#include <stdatomic.h>

#define LOG_CORECLR(...)
//#define LOG_CORECLR(...) fprintf (__VA_ARGS__)

#ifdef __cplusplus
extern "C" {
#endif

enum MonoObjectType : int {
	MonoObjectType_Unknown,
	MonoObjectType_Object,
	MonoObjectType_MonoReflectionMethod,
	MonoObjectType_MonoReflectionAssembly,
	MonoObjectType_MonoReflectionType,
	MonoObjectType_MonoArray,
	MonoObjectType_MonoString,
};

// We need a way to represent a managed object in native code, and since most
// our existing runtime code uses MonoObjects, we use the same for the CoreCLR
// bridge, just our own version of it. In Mono, the MonoObjects are tracked by
// the GC (which scans the stack), but we can't make CoreCLR scan the stack,
// so we use a reference counted version of MonoObject instead - we just put
// the GCHandle into a reference counted MonoObject, and when the MonoObject
// is freed, then we free the GCHandle as well.
//
// This struct must be kept in sync with the MonoObject struct in Runtime.CoreCLR.cs
struct _MonoObject {
	int _Atomic reference_count;
	enum MonoObjectType object_kind;
	GCHandle gchandle;
	char *type_name;
	void *struct_value;
};

struct _MonoAssembly {
	char *name;
	MonoImage *image;
	MonoReflectionAssembly *obj;
};

struct _MonoAssemblyName {
	char *name;
};

struct _MonoImage {
	char *name;
};

struct _MonoClass {
	char *fullname;
	GCHandle gchandle;
	char *name;
	char *name_space;
};

struct _MonoDomain {
	char *name;
};

struct _MonoMethod {
	char *name;
	MonoClass *klass;
	int param_count;
	GCHandle gchandle_tmp;
};

struct __MethodParameter {
	const char *type_name;
	GCHandle type_gchandle;
};

struct _MonoMethodSignature {
	char *name;
	MonoMethod *method;
	int parameter_count;
	struct __MethodParameter *parameters;
};

struct _MonoType {
	char *fullname;
	GCHandle gchandle;
	char *name;
	char *name_space;
	MonoTypeEnum type;
};

struct MonoVTable {
	char *name;
};

struct _MonoClassField {
	char *name;
};

struct _MonoThread {
	char *name;
};

struct _MonoThreadsSync {
	char *name;
};

struct _MonoReferenceQueue {
	GCHandle gchandle;
};

struct _MonoGHashTable {
	GCHandle gchandle;
};

struct _MonoString : MonoObject {
};

struct _MonoArray : MonoObject {
	uint64_t length;
	uint8_t *data;
};

struct _MonoReflectionMethod : MonoObject {
	MonoMethod *method;
	char *name;
};

struct _MonoReflectionAssembly : MonoObject {
	char *name;
	MonoAssembly *assembly;
};

struct _MonoReflectionType : MonoObject {
	char *name;
	MonoType *type;
};

struct _MonoException : MonoObject {
	char *name;
};

void
xamarin_coreclr_reference_tracking_begin_end_callback (int number);

int
xamarin_coreclr_reference_tracking_is_referenced_callback (void* ptr);

void
xamarin_coreclr_reference_tracking_tracked_object_entered_finalization (void* ptr);

MonoType *
xamarin_create_mono_type (const char *name, GCHandle gchandle, GCHandle* exception_gchandle = NULL);

MONO_API MonoClass *
xamarin_bridge_mono_class_from_name (MonoImage * image, const char * name_space, const char * name);

MONO_API MonoMethod *
xamarin_bridge_mono_class_get_method_from_name (MonoClass * klass, const char * name, int param_count);

MONO_API MonoClassField *
xamarin_bridge_mono_class_get_field_from_name (MonoClass * klass, const char * name);

MONO_API mono_bool
xamarin_bridge_mono_class_is_assignable_from (MonoClass * klass, MonoClass * oklass);

MONO_API MonoClass *
xamarin_bridge_mono_class_from_mono_type (MonoType * type);

MONO_API mono_bool
xamarin_bridge_mono_class_is_delegate (MonoClass * klass);

MONO_API MonoClass *
xamarin_bridge_mono_class_get_element_class (MonoClass * klass);

MONO_API const char *
xamarin_bridge_mono_class_get_namespace (MonoClass * klass);

MONO_API const char *
xamarin_bridge_mono_class_get_name (MonoClass * klass);

MONO_API MonoClass *
xamarin_bridge_mono_class_get_parent (MonoClass * klass);

MONO_API mono_bool
xamarin_bridge_mono_class_is_subclass_of (MonoClass * klass, MonoClass * klassc, mono_bool check_interfaces);

MONO_API mono_bool
xamarin_bridge_mono_class_is_valuetype (MonoClass * klass);

MONO_API mono_bool
xamarin_bridge_mono_class_is_enum (MonoClass * klass);

MONO_API MonoType *
xamarin_bridge_mono_class_enum_basetype (MonoClass * klass);

MONO_API int32_t
xamarin_bridge_mono_class_value_size (MonoClass * klass, uint32_t * align);

MONO_API MonoType *
xamarin_bridge_mono_class_get_type (MonoClass * klass);

MONO_API gboolean
xamarin_bridge_mono_class_is_nullable (MonoClass * klass);

MONO_API MonoClass *
xamarin_bridge_mono_class_get_nullable_param (MonoClass * klass);

MONO_API char *
xamarin_bridge_mono_method_full_name (MonoMethod * method, mono_bool signature);

/* REVIEW COMPLETED */
MONO_API MonoObject *
xamarin_bridge_mono_runtime_invoke (MonoMethod * method, void * obj, void ** params, MonoObject ** exc);

MONO_API void
xamarin_bridge_mono_raise_exception (MonoException * ex);

/* REVIEW COMPLETED */
MONO_API MonoString *
xamarin_bridge_mono_string_new (MonoDomain * domain, const char * text);

MONO_API MonoArray *
xamarin_bridge_mono_array_new (MonoDomain * domain, MonoClass * eclass, uintptr_t n);

MONO_API void *
xamarin_bridge_mono_object_unbox (MonoObject * obj);

MONO_API char *
xamarin_bridge_mono_string_to_utf8 (MonoString * string_obj);

/* REVIEW COMPLETED */
MONO_API MonoObject *
xamarin_bridge_mono_object_new (MonoDomain * domain, MonoClass * klass);

/* REVIEW COMPLETED */
MONO_API uintptr_t
xamarin_bridge_mono_array_length (MonoArray * array);

/* REVIEW COMPLETED */
MONO_API MonoObject *
xamarin_bridge_mono_object_isinst (MonoObject * obj, MonoClass * klass);

MONO_API MonoClass *
xamarin_bridge_mono_object_get_class (MonoObject * obj);

MONO_API MonoMethod *
xamarin_bridge_mono_object_get_virtual_method (MonoObject * obj, MonoMethod * method);

MONO_API void
xamarin_bridge_mono_field_get_value (MonoObject * obj, MonoClassField * field, void * value);

/* REVIEW COMPLETED */
MONO_API MonoObject *
xamarin_bridge_mono_value_box (MonoDomain * domain, MonoClass * klass, void * val);

MONO_API void
xamarin_bridge_mono_profiler_install (MonoProfiler * prof, MonoProfileFunc shutdown_callback);

MONO_API void
xamarin_bridge_mono_profiler_install_thread (MonoProfileThreadFunc start, MonoProfileThreadFunc end);

MONO_API void
xamarin_bridge_mono_profiler_install_gc (MonoProfileGCFunc callback, MonoProfileGCResizeFunc heap_resize_callback);

MONO_API void
xamarin_bridge_mono_profiler_load (const char * desc);

MONO_API mono_bool
xamarin_bridge_mono_thread_is_foreign (MonoThread * thread);

MONO_API MonoThread *
xamarin_bridge_mono_thread_current (void);

MONO_API MonoThread *
xamarin_bridge_mono_thread_attach (MonoDomain * domain);

MONO_API mono_bool
xamarin_bridge_mono_thread_detach_if_exiting (void);

MONO_API void
xamarin_bridge_mono_runtime_set_pending_exception (MonoException * exc, mono_bool overwrite);

MONO_API void
xamarin_bridge_mono_set_assemblies_path (const char * path);

MONO_API MonoAssembly *
xamarin_bridge_mono_assembly_open (const char * filename, MonoImageOpenStatus * status);

MONO_API MonoImage *
xamarin_bridge_mono_assembly_get_image (MonoAssembly * assembly);

MONO_API MonoAssemblyName *
xamarin_bridge_mono_assembly_name_new (const char * name);

MONO_API void
xamarin_bridge_mono_assembly_name_free (MonoAssemblyName * aname);

MONO_API MonoAssembly *
xamarin_bridge_mono_assembly_loaded (MonoAssemblyName * aname);

MONO_API void
xamarin_bridge_mono_register_machine_config (const char * config_xml);

MONO_API void
xamarin_bridge_mono_set_dirs (const char * assembly_dir, const char * config_dir);

MONO_API const char *
xamarin_bridge_mono_assembly_name_get_name (MonoAssemblyName * aname);

MONO_API const char *
xamarin_bridge_mono_assembly_name_get_culture (MonoAssemblyName * aname);

MONO_API void
xamarin_bridge_mono_install_assembly_preload_hook (MonoAssemblyPreLoadFunc func, void * user_data);

MONO_API MonoAssemblyName *
xamarin_bridge_mono_assembly_get_name (MonoAssembly * assembly);

MONO_API void
xamarin_bridge_mono_add_internal_call (const char * name, const void * method);

MONO_API void
xamarin_bridge_mono_dangerous_add_raw_internal_call (const char * name, const void * method);

MONO_API MonoMethodSignature *
xamarin_bridge_mono_method_signature (MonoMethod * method);

MONO_API MonoClass *
xamarin_bridge_mono_method_get_class (MonoMethod * method);

MONO_API void
xamarin_bridge_mono_dllmap_insert (MonoImage * assembly, const char * dll, const char * func, const char * tdll, const char * tfunc);

MONO_API MonoDomain *
xamarin_bridge_mono_domain_get (void);

MONO_API MonoClass *
xamarin_bridge_mono_get_intptr_class (void);

MONO_API MonoClass *
xamarin_bridge_mono_get_string_class (void);

MONO_API MonoImage *
xamarin_bridge_mono_get_corlib (void);

MONO_API MonoClass *
xamarin_bridge_mono_get_array_class (void);

MONO_API MonoClass *
xamarin_bridge_mono_get_exception_class (void);

MONO_API MonoDomain *
xamarin_bridge_mono_get_root_domain (void);

MONO_API void
xamarin_bridge_mono_domain_set_config (MonoDomain * domain, const char * base_dir, const char * config_file_name);

MONO_API MonoReflectionAssembly *
xamarin_bridge_mono_assembly_get_object (MonoDomain * domain, MonoAssembly * assembly);

MONO_API MonoReflectionMethod *
xamarin_bridge_mono_method_get_object (MonoDomain * domain, MonoMethod * method, MonoClass * refclass);

MONO_API MonoReflectionType *
xamarin_bridge_mono_type_get_object (MonoDomain * domain, MonoType * type);

MONO_API MonoType *
xamarin_bridge_mono_reflection_type_get_type (MonoReflectionType * reftype);

MONO_API MonoType *
xamarin_bridge_mono_signature_get_params (MonoMethodSignature * sig, void ** iter);

MONO_API mono_bool
xamarin_bridge_mono_type_is_byref (MonoType * type);

MONO_API MonoType *
xamarin_bridge_mono_signature_get_return_type (MonoMethodSignature * sig);

MONO_API int
xamarin_bridge_mono_type_get_type (MonoType * type);

MONO_API void
xamarin_bridge_mono_debug_init (MonoDebugFormat format);

MONO_API void
xamarin_bridge_mono_gc_collect (int generation);

MONO_API mono_bool
xamarin_bridge_mono_is_debugger_attached (void);

MONO_API void
xamarin_bridge_mono_config_parse_memory (const char * buffer);

MONO_API int
xamarin_bridge_mono_gc_max_generation (void);

MONO_API MonoGHashTable *
xamarin_bridge_mono_g_hash_table_new_type (GHashFunc hash_func, GEqualFunc key_equal_func, MonoGHashGCType type);

/* REVIEW COMPLETE */
MONO_API gpointer
xamarin_bridge_mono_g_hash_table_lookup (MonoGHashTable * hash, gconstpointer key);

MONO_API void
xamarin_bridge_mono_g_hash_table_insert (MonoGHashTable * hash, gpointer k, gpointer v);

MONO_API MonoException *
xamarin_bridge_mono_get_exception_execution_engine (const char * msg);

MONO_API MonoException *
xamarin_bridge_mono_exception_from_name_msg (MonoImage * image, const char * name_space, const char * name, const char * msg);

MONO_API MonoException *
xamarin_bridge_mono_get_exception_out_of_memory (void);

MONO_API MonoReferenceQueue *
xamarin_bridge_mono_gc_reference_queue_new (mono_reference_queue_callback callback);

MONO_API void
xamarin_bridge_mono_gc_reference_queue_free (MonoReferenceQueue * queue);

MONO_API gboolean
xamarin_bridge_mono_gc_reference_queue_add (MonoReferenceQueue * queue, MonoObject * obj, void * user_data);

MONO_API void
xamarin_bridge_mono_gc_register_finalizer_callbacks (MonoGCFinalizerCallbacks * callbacks);

MONO_API void
xamarin_bridge_mono_gc_toggleref_register_callback (MonoToggleRefCallback process_toggleref);

MONO_API gchar *
xamarin_bridge_mono_path_resolve_symlinks (const char * path);

MONO_API void
xamarin_bridge_mono_free (void * ptr);

MONO_API char *
xamarin_bridge_mono_get_runtime_build_info (void);

MONO_API MonoDomain *
xamarin_bridge_mono_jit_init_version (const char * root_domain_name, const char * runtime_version);

MONO_API MonoDomain *
xamarin_bridge_mono_jit_init (const char * file);

MONO_API int
xamarin_bridge_mono_jit_exec (MonoDomain * domain, MonoAssembly * assembly, int argc, const char** argv);

MONO_API void
xamarin_bridge_mono_jit_parse_options (int argc, char** argv);

MONO_API void
xamarin_bridge_mono_jit_set_aot_mode (MonoAotMode mode);

MONO_API void
xamarin_bridge_mono_set_signal_chaining (mono_bool chain_signals);

MONO_API void
xamarin_bridge_mono_set_crash_chaining (mono_bool chain_signals);

MONO_API void
xamarin_bridge_mono_jit_set_trace_options (const char * option);

MONO_API void*
xamarin_bridge_mono_jit_thread_attach (MonoDomain * domain);

MONO_API gboolean
xamarin_bridge_mono_exception_walk_trace (MonoException * exc, MonoExceptionFrameWalk func, gpointer user_data);

MONO_API void
xamarin_bridge_mono_install_unhandled_exception_hook (MonoUnhandledExceptionFunc func, gpointer user_data);

MONO_API int
xamarin_bridge_mono_main (int argc, char ** argv);

MONO_API void
xamarin_bridge_mono_install_load_aot_data_hook (MonoLoadAotDataFunc load_func, MonoFreeAotDataFunc free_func, gpointer user_data);

MONO_API gboolean
xamarin_bridge_mini_parse_debug_option (const char * option);

MONO_API void
xamarin_bridge_mono_trace_set_log_handler (MonoLogCallback callback, void * user_data);

MONO_API void
xamarin_bridge_mono_trace_set_print_handler (MonoPrintCallback callback);

MONO_API void
xamarin_bridge_mono_trace_set_printerr_handler (MonoPrintCallback callback);

MONO_API void*
xamarin_bridge_mono_threads_enter_gc_unsafe_region (void ** stackdata);

MONO_API void
xamarin_bridge_mono_threads_exit_gc_unsafe_region (void * cookie, void ** stackdata);

MONO_API void*
xamarin_bridge_mono_threads_enter_gc_safe_region (void ** stackdata);

MONO_API void
xamarin_bridge_mono_threads_exit_gc_safe_region (void * cookie, void ** stackdata);

MONO_API void
xamarin_bridge_mono_threads_assert_gc_safe_region (void);

MONO_API void
xamarin_bridge_mono_threads_assert_gc_unsafe_region (void);

MONO_API void
xamarin_bridge_mono_threads_assert_gc_starting_region (void);

MONO_API void*
xamarin_bridge_mono_thread_info_current_unchecked (void);

MONO_API void *
xamarin_bridge_mono_threads_attach_coop (MonoDomain * domain, gpointer* dummy);

MONO_API void *
xamarin_bridge_mono_threads_detach_coop (gpointer cookie, gpointer* dummy);

MONO_API void
xamarin_bridge_mono_install_ftnptr_eh_callback (MonoFtnPtrEHCallback callback);

MONO_API void
xamarin_bridge_mono_debugger_agent_parse_options (const char * options);

MONO_API gboolean
xamarin_bridge_mono_debugger_agent_transport_handshake (void);

MONO_API void
xamarin_bridge_mono_debugger_agent_register_transport (DebuggerTransport * trans);

#ifdef __cplusplus
} /* extern "C" */
#endif

#endif /* __CORECLR_BRIDGE__ */

#endif // CORECLR_RUNTIME
