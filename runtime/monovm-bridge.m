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
xamarin_vm_initialize (int propertyCount, const char **propertyKeys, const char **propertyValues)
{
	int rv;

	rv = monovm_initialize (propertyCount, propertyKeys, propertyValues);

	fprintf (stderr, "xamarin_vm_initialize (%i, %p, %p): rv: %i\n", propertyCount, propertyKeys, propertyValues, rv);

	return rv == 0;
}

#endif // !CORECLR_RUNTIME