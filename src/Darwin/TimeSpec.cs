
#nullable enable

namespace Darwin {
	/// <summary>To be added.</summary>
	[StructLayout (LayoutKind.Sequential)]
	[NativeName ("timespec")]
	public struct TimeSpec {
		/// <summary>To be added.</summary>
		public nint Seconds;
		/// <summary>To be added.</summary>
		public nint NanoSeconds;
	}
}
