using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

using NUnit.Framework;

using Mono.Cecil;
using Mono.Cecil.Cil;

using ObjCRuntime;

using Xamarin.Tests;
using Xamarin.Utils;

#nullable enable

namespace Cecil.Tests {
	[TestFixture]
	public partial class StaticConstructors {
		[Test]
		public void VerifyNoMoreStaticConstructors ()
		{
			// We join all the APIs from all the platforms, so we can only run this test when all platforms are enabled.
			Configuration.IgnoreIfAnyIgnoredPlatforms ();

			// Collect everything
			var staticConstructors = new Dictionary<string, MethodDefinition> ();
			foreach (var info in Helper.NetPlatformImplementationAssemblyDefinitions) {
				var cctors = info.Assembly.EnumerateMethods (v => {
					// Console.WriteLine (v);
					return v.IsStatic && v.IsConstructor;
					});
				foreach (var cctor in cctors) {
					staticConstructors [cctor.DeclaringType.FullName] = cctor;
				}
			}
			var failures = staticConstructors.Keys.OrderBy (v => v);

			var knownfailuresFilename = $"StaticConstructors.KnownFailures.txt";
			var knownfailuresPath = Path.Combine (Configuration.SourceRoot, "tests", "cecil-tests", knownfailuresFilename);
			var knownfailures = File.Exists (knownfailuresPath) ? File.ReadAllLines (knownfailuresPath) : Array.Empty<string> ();

			var unknownFailures = failures.Except (knownfailures).OrderBy (v => v).ToList ();
			var fixedFailures = knownfailures.Except (failures).OrderBy (v => v).ToList ();

			if (unknownFailures.Any () || fixedFailures.Any ()) {
				if (!string.IsNullOrEmpty (Environment.GetEnvironmentVariable ("WRITE_KNOWN_FAILURES"))) {
					File.WriteAllLines (knownfailuresPath, failures);
					Assert.Fail ($"Found {unknownFailures.Count} new types with static constructors (not known failures) and {fixedFailures.Count} types without static constructors that were marked as known failures. The known failures have been updated, so please commit the results. Re-running the test should now succeed.");
				} else {
					if (unknownFailures.Any ()) {
						Console.WriteLine ($"Types with static constructors that aren't known failures (found {unknownFailures.Count}, showing at most 10):");
						foreach (var failure in unknownFailures.Take (10))
							Console.WriteLine ($"    {failure}");
						if (unknownFailures.Count > 10)
							Console.WriteLine ($"    ... and {unknownFailures.Count () - 10} more");
					}
					if (fixedFailures.Any ()) {
						Console.WriteLine ($"Types without static constructors that are known failures (found {fixedFailures.Count}, showing at most 10):");
						foreach (var failure in fixedFailures.Take (10))
							Console.WriteLine ($"    {failure}");
						if (fixedFailures.Count > 10)
							Console.WriteLine ($"    ... and {fixedFailures.Count () - 10} more");
					}
					Assert.Fail ($"Found {unknownFailures.Count} new types with static constructors (not known failures) and {fixedFailures.Count} types without static constructors that were marked as known failures. If this is expected, set the WRITE_KNOWN_FAILURES=1 environment variable, run the test again, and commit the modified known failures file.");
				}
			}
		}
	}
}
