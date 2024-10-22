using System.Collections.Generic;
using Microsoft.DotNet.XHarness.iOS.Shared;
using Microsoft.DotNet.XHarness.iOS.Shared.Hardware;

namespace Xharness.Jenkins {

	class TestData {
		public string Variation;
		public string AppBundleExtraOptions;
		public KnownIssue KnownFailure;
		public bool Debug;
		public bool Profiling;
		public string LinkMode;
		public string Defines;
		public string Undefines;
		public bool? Ignored;
		public bool EnableSGenConc;
		public bool UseLlvm;
		public bool? UseMonoRuntime;
		public IEnumerable<IDevice> Candidates;
		public string RuntimeIdentifier;
		public string Registrar;
		public bool PublishAot; // NativeAOT
	}
}
