
#nullable enable

namespace Darwin {
	/// <summary>Represents a POSIX time specification with seconds and nanoseconds.</summary>
	[StructLayout (LayoutKind.Sequential)]
	[NativeName ("timespec")]
	public struct TimeSpec {
		/// <summary>The number of seconds.</summary>
		public nint Seconds;
		/// <summary>The number of nanoseconds.</summary>
		public nint NanoSeconds;
	}
}
