
#nullable enable

namespace CoreTelephony {

	// untyped enum -> CoreTelephonyDefines.h
	// in header file this is used inside a CTError structure where the domain is a SInt32
	/// <summary>An enumeration whose values specify an error domain.</summary>
	public enum CTErrorDomain {
		/// <summary>Indicates no error.</summary>
		NoError = 0,
		/// <summary>Indicates posix.</summary>
		Posix = 1,
		/// <summary>Indicates mach.</summary>
		Mach = 2,
	}

	/// <summary>Enumerates data restrictions for <see cref="CoreTelephony.CTCellularData.RestrictedState" />.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum CTCellularDataRestrictedState : ulong {
		/// <summary>Indicates unknown.</summary>
		Unknown,
		/// <summary>Indicates restricted.</summary>
		Restricted,
		/// <summary>Indicates not restricted.</summary>
		NotRestricted,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum CTCellularPlanProvisioningAddPlanResult : long {
		/// <summary>Indicates unknown.</summary>
		Unknown,
		/// <summary>Indicates fail.</summary>
		Fail,
		/// <summary>Indicates success.</summary>
		Success,
		[iOS (17, 0)]
		Cancel,
	}
}
