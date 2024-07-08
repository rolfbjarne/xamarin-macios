#if NET
using System.Runtime.InteropServices;

#nullable enable

namespace FSKit {
	[StructLayout (LayoutKind.Sequential)]
	public struct FSMetaReadahead
	{
		public long Fffset;
		public nuint Length;
	}
}
#endif
