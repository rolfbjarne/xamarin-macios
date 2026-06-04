//
// IOSurface
//
// Authors: 
//    Miguel de Icaza (miguel@xamarin.com)
//
// Copyright 2017 Microsoft
//

#nullable enable

namespace IOSurface {

	/// <summary>To be added.</summary>
	public enum IOSurfaceLockOptions : uint {
		/// <summary>Indicates read only.</summary>
		ReadOnly = 1,
		/// <summary>Indicates avoid sync.</summary>
		AvoidSync = 2,
	}

	/// <summary>To be added.</summary>
	public enum IOSurfacePurgeabilityState : uint {
		/// <summary>Indicates non volatile.</summary>
		NonVolatile = 0,
		/// <summary>Indicates volatile.</summary>
		Volatile = 1,
		/// <summary>Indicates empty.</summary>
		Empty = 2,
		/// <summary>Indicates keep current.</summary>
		KeepCurrent = 3,
	}

	// To be used with kIOSurfaceCacheMode or IOSurfacePropertyKeyCacheMode
	/// <summary>To be added.</summary>
	public enum IOSurfaceMemoryMap {
		/// <summary>Indicates default cache.</summary>
		DefaultCache = 0,
		/// <summary>Indicates inhibit cache.</summary>
		InhibitCache = 1 << 8,
		/// <summary>Indicates write thru cache.</summary>
		WriteThruCache = 2 << 8,
		/// <summary>Indicates copyback cache.</summary>
		CopybackCache = 3 << 8,
		/// <summary>Indicates write combine cache.</summary>
		WriteCombineCache = 4 << 8,
		/// <summary>Indicates copyback inner cache.</summary>
		CopybackInnerCache = 5 << 8,
	};


}
