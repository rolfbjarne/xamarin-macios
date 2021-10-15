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

		public static bool operator == (NativeHandle left, IntPtr right)
		{
			return left.handle == right;
		}

		public static bool operator == (NativeHandle left, NativeHandle right)
		{
			return left.handle == right.handle;
		}

		public static bool operator == (IntPtr left, NativeHandle right)
		{
			return left == right.Handle;
		}

		public static bool operator != (NativeHandle left, IntPtr right)
		{
			return left.handle != right;
		}

		public static bool operator != (IntPtr left, NativeHandle right)
		{
			return left != right.Handle;
		}

		public static bool operator != (NativeHandle left, NativeHandle right)
		{
			return left.handle != right.Handle;
		}

#if IMPLICITWHILEIMPLEMENTING
		public static explicit operator IntPtr (NativeHandle value)
#else
		public static implicit operator IntPtr (NativeHandle value)
#endif
		{
			return value.Handle;
		}
#if IMPLICITWHILEIMPLEMENTING
		public static explicit operator NativeHandle (IntPtr value)
#else
		public static implicit operator NativeHandle (IntPtr value)
#endif
		{
			return new NativeHandle (value);
		}

		public override bool Equals (object o)
		{
			if (o is NativeHandle nh)
				return nh.handle == this.handle;
			return false;
		}

		public override int GetHashCode ()
		{
			return handle.GetHashCode ();
		}
	}
}
#endif
