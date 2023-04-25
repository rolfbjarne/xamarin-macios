using System;

using Foundation;

namespace MyClassLibrary {
	public class MyClass {
		public MyClass ()
		{
		}
		static void Main () {}

		[System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute (EntryPoint = "theAnswer")]
		static int TheAnswer ()
		{
			return 42;
		}

		[System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute (EntryPoint = "theQuestion")]
		static IntPtr TheQuestion ()
		{
			using var str = new NSString ("Life, the universe and everything");
			str.DangerousRetain ();
			str.DangerousAutorelease ();
			return str.Handle;
		}
	}
}
