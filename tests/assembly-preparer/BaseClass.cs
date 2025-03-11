namespace AssemblyPreparerTests;

public abstract class BaseClass {
	public void AssertPrepare (AssemblyPreparer preparer)
	{
		if (!preparer.Prepare (out var exceptions))
			Assert.Fail ($"Prepare failed, exceptions:\n\t{string.Join ("\n\t", exceptions.Select (v => v.ToString ()))}");
		Assert.That (exceptions, Is.Empty, "Exceptions");
	}

	public bool AssertPrepare (ApplePlatform platform, string code, out AssemblyDefinition assemblyDefinition)
	{
		AssertPrepare (platform, code, out assemblyDefinition);
	}

	public void AssertPrepare (ApplePlatform platform, string code, out AssemblyDefinition assemblyDefinition)
	{
		AssertPrepareCode (platform, null, code, out string outputPath);
		assemblyDefinition = AssemblyDefinition.ReadAssembly (outputPath);
		return rv;
	}

	// returns true if the test assembly was modified
	public bool AssertPrepareCode (ApplePlatform platform, Action<AssemblyPreparer>? configure, string code, out string outputPath)
	{
		Configuration.IgnoreIfIgnoredPlatform (platform);

		var csproj = $@"
<Project Sdk=""Microsoft.NET.Sdk"">
	<PropertyGroup>
		<TargetFramework>net$(BundledNETCoreAppTargetFrameworkVersion)-{platform.AsString ().ToLower ()}</TargetFramework>
        <AppendTargetFrameworkToOutputPath>false</AppendTargetFrameworkToOutputPath>
		<UseFloatingTargetPlatformVersion>true</UseFloatingTargetPlatformVersion>
	</PropertyGroup>
</Project>
    ";

		var tmpdir = Cache.CreateTemporaryDirectory ();
		File.WriteAllText (Path.Combine (tmpdir, "Test.cs"), code);
		var csprojPath = Path.Combine (tmpdir, "Test.csproj");
		File.WriteAllText (csprojPath, csproj);
		DotNet.AssertBuild (csprojPath);
		var assemblyDir = Path.Combine (tmpdir, "bin", "Debug");

		var assemblies = Configuration.GetReferenceAssemblies (platform);
		assemblies.Add (Path.Combine (assemblyDir, "Test.dll"));
		var infos = assemblies.Select (v => new AssemblyPreparerInfo (v, Path.Combine (assemblyDir, "out", Path.GetFileName (v)))).ToArray ();
		var preparer = new AssemblyPreparer (infos, platform);
		if (configure is not null)
			configure (preparer);
		AssertPrepare (preparer);
		
		var testInfo = infos.Single (v => Path.GetFileNameWithoutExtension (v.InputPath) == "Test");
		outputPath = testInfo.OutputPath;
		Console.WriteLine ("Output assembly: " + outputPath);
		return testInfo.InputPath != testInfo.OutputPath;
	}
}
