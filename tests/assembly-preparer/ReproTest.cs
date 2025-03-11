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
			var code = @"public class SomeLibrary {}";

			reproPath = Xamarin.Cache.CreateTemporaryDirectory ();
			Directory.Delete (reproPath); // the repro path can't exist prior to Prepare
			AssertPrepareCode (platform, (preparer) => {
				preparer.MakeReproPath = reproPath;
				preparer.Registrar = RegistrarMode.Dynamic;
			}, code, out string _);
		}

		var lines = File.ReadAllLines (Path.Combine (reproPath, "arguments.txt"));

		var ap = AssemblyPreparer.LoadFromReproPath (reproPath);
		ap.MakeReproPath = Xamarin.Cache.CreateTemporaryDirectory ();
		Directory.Delete (ap.MakeReproPath); // the repro path can't exist prior to Prepare
		AssertPrepare (ap);

		var lines2 = File.ReadAllLines (Path.Combine (ap.MakeReproPath, "arguments.txt"));
		Assert.That (lines, Is.EqualTo (lines2), "Repro arguments match");
	}
}
