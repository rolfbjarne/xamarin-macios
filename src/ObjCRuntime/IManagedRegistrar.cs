//
// IManagedRegistrar.cs
//
// Authors:
//   Rolf Bjarne Kvinge
//
// Copyright 2023 Microsoft Corp


#if NET

#nullable enable

using System;

namespace ObjCRuntime {
	// The managed static registrar will make this interface public when needed.
	interface IManagedRegistrar {
		IntPtr LookupUnmanagedFunction (string? symbol, int id);
		RuntimeTypeHandle LookupType (uint id);
		uint LookupTypeId (RuntimeTypeHandle handle);
		void RegisterWrapperTypes (Dictionary<RuntimeTypeHandle, RuntimeTypeHandle> type);
	}
}

#endif // NET
