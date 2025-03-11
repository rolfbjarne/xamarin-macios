namespace AssemblyPreparerTests;

public class ReproTest : BaseClass {
	[TestCase (ApplePlatform.iOS)]
	public void RoundTrip (ApplePlatform platform)
	{
		Configuration.IgnoreIfIgnoredPlatform (platform);

		// build once with a repro path
		// load everything from the repro path, prepare again (with a different repro path this time),
		// and verify that the arguments.txt files from each preparation are identical
		//
		// this test can also be repurposed to run an existing repro by setting the _PrepareAssembliesMakeReproPath variable

		var reproPath = Environment.GetEnvironmentVariable ("_PrepareAssembliesMakeReproPath");
		var referenceAssemblies = Configuration.GetReferenceAssemblies (platform);
		if (string.IsNullOrEmpty (reproPath)) {
			reproPath = Cache.CreateTemporaryDirectory ();

			var code = @"
			public class SomeLibrary {}";

			var csproj = $@"
	<Project Sdk=""Microsoft.NET.Sdk"">
		<PropertyGroup>
			<TargetFramework>net$(BundledNETCoreAppTargetFrameworkVersion)-{platform.AsString ().ToLower ()}</TargetFramework>
			<AppendTargetFrameworkToOutputPath>false</AppendTargetFrameworkToOutputPath>
		</PropertyGroup>
	</Project>
		";

			var tmpdir = Cache.CreateTemporaryDirectory ();
			File.WriteAllText (Path.Combine (tmpdir, "Test.cs"), code);
			var csprojPath = Path.Combine (tmpdir, "Test.csproj");
			File.WriteAllText (csprojPath, csproj);
			DotNet.AssertBuild (csprojPath);
			var assemblyDir = Path.Combine (tmpdir, "bin", "Debug");

			var testAssemblies = new List<string> (referenceAssemblies) {
				Path.Combine (assemblyDir, "Test.dll")
			};
			var infos = testAssemblies.Select (v => new AssemblyPreparerInfo (v, Path.Combine (assemblyDir, "out", Path.GetFileName (v)))).ToArray ();
			var preparer = new AssemblyPreparer (infos, platform);
			preparer.MakeReproPath = reproPath;
			Directory.Delete (reproPath); // the repro path can't exist prior to Prepare
			AssertPrepare (preparer);
		}

		var reproPath2 = Cache.CreateTemporaryDirectory ();
		var assemblies = new List<AssemblyPreparerInfo> ();
		var lines = File.ReadAllLines (Path.Combine (reproPath, "arguments.txt"));
		foreach (var line in lines) {
			if (line.StartsWith ("Platform: ")) {
				var platformStr = line.Substring ("Platform: ".Length);
				platform = Enum.Parse<ApplePlatform> (platformStr);
			} else if (line.StartsWith ("Assembly: ")) {
				var assembly = line.Substring ("Assembly: ".Length);
				assemblies.Add (new AssemblyPreparerInfo (Path.Combine (reproPath, assembly), Path.Combine (reproPath, "out", assembly)));
			} else {
				throw new Exception ($"Unknown line: {line}");
			}
		}
		var ap = new AssemblyPreparer (assemblies.ToArray (), platform);
		ap.MakeReproPath = reproPath2;
		Directory.Delete (reproPath2); // the repro path can't exist prior to Prepare
		AssertPrepare (ap);

		var lines2 = File.ReadAllLines (Path.Combine (reproPath2, "arguments.txt"));
		Assert.That (lines, Is.EqualTo (lines2), "Repro arguments match");
	}
}
