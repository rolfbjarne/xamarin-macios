using System.Runtime.InteropServices;

namespace FrameworksInRuntimesNativeDirectory {
	public static class PInvokes {
		[DllImport ("@rpath/XTest.framework/XTest")]
		public static extern int getXTest2 ();
	}
}
