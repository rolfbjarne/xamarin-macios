#nullable enable

using System;

namespace ObjCRuntime {

	public interface INativeObject {
#if !COREBUILD
		IntPtr Handle { 
			get;
		}
#endif
	}

#if !COREBUILD
	public static class NativeObjectExtensions {

		// help to avoid the (too common pattern)
		// 	var p = x == null ? IntPtr.Zero : x.Handle;
		static public IntPtr GetHandle (this INativeObject? self)
		{
			return self == null ? IntPtr.Zero : self.Handle;
		}

		static public IntPtr GetNonNullHandle (this INativeObject self, string argumentName)
		{
			if (self is null)
				ThrowHelper.ThrowArgumentNullException (argumentName);
			if (self.Handle == IntPtr.Zero)
				ThrowHelper.ThrowObjectDisposedException (self);
			return self.Handle;
		}

		public static IntPtr GetCheckedHandle (this INativeObject self)
		{
			if (self.Handle == IntPtr.Zero)
				ObjCRuntime.ThrowHelper.ThrowObjectDisposedException (self);
			return self.Handle;
		}
	}
#endif
}
