
/* Support for using CoreCLR */

#if defined (CORECLR_RUNTIME)

#ifndef __CORECLR_BRIDGE__
#define __CORECLR_BRIDGE__

#include <stdatomic.h>

#define LOG_CORECLR(...)
//#define LOG_CORECLR(...) fprintf (__VA_ARGS__)

#include "mono-runtime.h"

#ifdef __cplusplus
extern "C" {
#endif

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
	GCHandle gchandle;
	// We write the value of the struct here every time we create a MonoObject instance.
	// We can also fetch this value when it's needed (as opposed to creating it every time),
	// but that runs into threading issues (what if two threads needs it at the same time?).
	// Nothing unsolvable, but I'm going with the simplest solution until this is proven
	// to be a problem.
	void *struct_value;
};

// This struct must be kept in sync with the MonoMethodSignature struct in Runtime.CoreCLR.cs
struct _MonoMethodSignature {
	MonoObject *method;
	int parameter_count;
	MonoObject *return_type;
	MonoObject *parameters[];
};

void
xamarin_coreclr_reference_tracking_begin_end_callback ();

int
xamarin_coreclr_reference_tracking_is_referenced_callback (void* ptr);

void
xamarin_coreclr_reference_tracking_tracked_object_entered_finalization (void* ptr);

void
xamarin_coreclr_unhandled_exception_handler (void *context);

MonoObject *
xamarin_bridge_coreclr_runtime_invoke (MonoMethod * method, GCHandle obj, void ** params, MonoObject ** exc);

bool
xamarin_bridge_coreclr_object_isinst (GCHandle obj, MonoClass * klass);

MonoClass *
xamarin_bridge_coreclr_gchandle_get_class (GCHandle obj);

MonoType *
xamarin_create_mono_type (const char *name, GCHandle gchandle, GCHandle* exception_gchandle = NULL);

/* REVIEW COMPLETED */
MONO_API MonoObject *
xamarin_bridge_mono_runtime_invoke (MonoMethod * method, void * obj, void ** params, MonoObject ** exc);

MONO_API char *
xamarin_bridge_mono_string_to_utf8 (MonoString * string_obj);

MONO_API void
xamarin_bridge_mono_runtime_set_pending_exception (MonoException * exc, mono_bool overwrite);

MONO_API MonoAssembly *
xamarin_bridge_mono_assembly_open (const char * filename, MonoImageOpenStatus * status);

MONO_API void
xamarin_bridge_mono_domain_set_config (MonoDomain * domain, const char * base_dir, const char * config_file_name);

MONO_API MonoException *
xamarin_bridge_mono_get_exception_execution_engine (const char * msg);

MONO_API MonoException *
xamarin_bridge_mono_get_exception_out_of_memory (void);

MONO_API void
xamarin_bridge_mono_gc_register_finalizer_callbacks (MonoGCFinalizerCallbacks * callbacks);

MONO_API void
xamarin_bridge_mono_gc_toggleref_register_callback (MonoToggleRefCallback process_toggleref);

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
