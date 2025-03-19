namespace AssemblyPreparerTests;

public class ReproTest {
	[Test]
	public void Rerun ()
	{
		var reproPath = Environment.GetEnvironmentVariable ("_PrepareAssembliesMakeReproPath");
		if (string.IsNullOrEmpty (reproPath))
			reproPath = "/tmp/assembly-preparer-repro";
		if (!Directory.Exists (reproPath))
			return;

		var platform = ApplePlatform.None;
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
		ap.Prepare (out var exceptions);
	}
}
