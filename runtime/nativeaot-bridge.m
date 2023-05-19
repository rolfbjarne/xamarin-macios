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

extern "C" void xamarin_objcruntime_runtime_nativeaotinitialize (struct InitializationOptions* options, GCHandle* exception_gchandle);
void
xamarin_bridge_call_runtime_initialize (struct InitializationOptions* options, GCHandle* exception_gchandle)
{
	xamarin_objcruntime_runtime_nativeaotinitialize (options, exception_gchandle);
}

bool
xamarin_bridge_vm_initialize (int propertyCount, const char **propertyKeys, const char **propertyValues)
{
	return true;
}

#endif // NATIVEAOT
