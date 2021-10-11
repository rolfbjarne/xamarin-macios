#if NET

using System;

namespace ObjCRuntime {
	public readonly struct NativeHandle {
		readonly IntPtr handle;

		public IntPtr Handle { get { return handle; } }

		public static NativeHandle Zero = default (NativeHandle);

		public NativeHandle (IntPtr handle)
		{
			this.handle = handle;
		}
	}
}
#endif
