#nullable enable

#if MONOMAC

using System;
using System.Runtime.InteropServices;

using ObjCRuntime;

namespace MediaToolbox {

#if NET
	[SupportedOSPlatform ("macos12.0")]
#endif
	static public class MTProfessionalVideoWorkflow {

#if NET
		[SupportedOSPlatform ("macos12.0")]
#endif
		[DllImport (Constants.MediaToolboxLibrary, EntryPoint = "MTRegisterProfessionalVideoWorkflowFormatReaders")]
		public static extern void RegisterFormatReaders ();
	}
}

#endif
