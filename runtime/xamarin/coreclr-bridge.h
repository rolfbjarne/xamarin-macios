
/* Wrapping support for CoreCLR */

#if defined(CORECLR_RUNTIME)

#ifndef __CORECLR_BRIDGE__
#define __CORECLR_BRIDGE__

#ifdef __cplusplus
extern "C" {
#endif

enum MonoObjectType : int {
	MonoObjectType_Unknown,
	MonoObjectType_MonoReflectionMethod,
	MonoObjectType_MonoReflectionAssembly,
	MonoObjectType_MonoReflectionType,
	MonoObjectType_MonoArray,
};

struct _MonoObject {
	int _Atomic reference_count;
	enum MonoObjectType object_kind;
	GCHandle gchandle;
	char *type_name;
	void *struct_value;

	void Release ();
	void Retain ();
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
	GCHandle gchandle;
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

struct _MonoString : MonoObject {
	char *value;
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

#ifdef __cplusplus
} /* extern "C" */
#endif

#endif /* __CORECLR_BRIDGE__ */

#endif // CORECLR_RUNTIME
