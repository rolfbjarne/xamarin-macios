//
// LinkerOptimize.cs: Apply this to methods to tell the linker to optimize them
//

using System;
using System.Runtime.InteropServices;

namespace XamCore.ObjCRuntime {

	[AttributeUsage (AttributeTargets.Method, AllowMultiple = false)]
	internal class LinkerOptimizeAttribute : Attribute { }
}
