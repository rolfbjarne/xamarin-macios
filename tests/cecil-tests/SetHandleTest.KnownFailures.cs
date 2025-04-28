using System.Collections.Generic;

#nullable enable

namespace Cecil.Tests {
	public partial class SetHandleTest {
		static HashSet<string> knownFailuresNobodyCallsHandleSetter = new HashSet<string> {
			// Runtime.RegisterNSObject shouldn't call InitializeHandle, so just mark this as a known failure.
			"ObjCRuntime.Runtime::RegisterNSObject(Foundation.NSObject,System.IntPtr)",
		};
	}
}
