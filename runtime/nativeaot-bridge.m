/* -*- Mode: C; tab-width: 8; indent-tabs-mode: t; c-basic-offset: 8 -*- */
/*
*  Authors: Rolf Bjarne Kvinge
*
*  Copyright (C) 2023 Microsoft Corp.
*
*/

#if defined (NATIVEAOT)

#include <sys/stat.h>
#include <inttypes.h>
#include <pthread.h>
#include <sys/mman.h>
#include <dlfcn.h>

#include "product.h"
#include "runtime-internal.h"
#include "slinked-list.h"
#include "xamarin/xamarin.h"
#include "xamarin/coreclr-bridge.h"

typedef void (*xamarin_runtime_initialize_decl)(struct InitializationOptions* options, GCHandle* exception_gchandle);
void
xamarin_bridge_call_runtime_initialize (struct InitializationOptions* options, GCHandle* exception_gchandle)
{
	void *del = dlsym (RTLD_DEFAULT, "xamarin_objcruntime_runtime_nativeaotinitialize");
	if (del == NULL)
		xamarin_assertion_message ("xamarin_bridge_call_runtime_initialize: failed to load xamarin_objcruntime_runtime_nativeaotinitialize: %s\n", dlerror ());

	xamarin_runtime_initialize_decl runtime_initialize = (xamarin_runtime_initialize_decl) del;
	runtime_initialize (options, exception_gchandle);
}

#endif // NATIVEAOT
