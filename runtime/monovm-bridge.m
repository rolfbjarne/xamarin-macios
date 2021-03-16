/* -*- Mode: C; tab-width: 8; indent-tabs-mode: t; c-basic-offset: 8 -*- */
/*
*  Authors: Rolf Bjarne Kvinge
*
*  Copyright (C) 2021 Microsoft Corp.
*
*/

/* Support code for using MonoVM */

#if !defined (CORECLR_RUNTIME)

#include "xamarin/xamarin.h"
#include "xamarin/monovm-bridge.h"

bool
xamarin_bridge_vm_initialize (int propertyCount, const char **propertyKeys, const char **propertyValues)
{
	int rv;

#if TARGET_OS_TV
	rv = 0;
	// Due to https://github.com/dotnet/runtime/issues/48508, we can't link with the .NET version libmonosgen-2.0.dylib,
	// which means that we can't call monovm_initialize here. Just ignore it for now.
	fprintf (stderr, "xamarin_vm_initialize (%i, %p, %p): Ignored due to https://github.com/dotnet/runtime/issues/48508.\n", propertyCount, propertyKeys, propertyValues);
#else

	rv = monovm_initialize (propertyCount, propertyKeys, propertyValues);

	fprintf (stderr, "xamarin_vm_initialize (%i, %p, %p): rv: %i\n", propertyCount, propertyKeys, propertyValues, rv);
#endif

	return rv == 0;
}

#endif // !CORECLR_RUNTIME