namespace AssemblyPreparerTests;

public abstract class BaseClass {
	public void AssertPrepare (AssemblyPreparer preparer)
	{
		if (!preparer.Prepare (out var exceptions))
			Assert.Fail ($"Prepare failed, exceptions:\n\t{string.Join ("\n\t", exceptions.Select (v => v.ToString ()))}");
		Assert.That (exceptions, Is.Empty, "Exceptions");
	}

	public void AssertPrepare (ApplePlatform platform, string code, out AssemblyDefinition assemblyDefinition)
	{
		AssertPrepare (platform, RegistrarMode.Dynamic, code, out assemblyDefinition);
	}

	public void AssertPrepare (ApplePlatform platform, RegistrarMode registrar, string code, out AssemblyDefinition assemblyDefinition)
	{
		AssertPrepareCode (platform, preparer => preparer.Registrar = registrar, code, out string outputPath);
		assemblyDefinition = AssemblyDefinition.ReadAssembly (outputPath);
	}

	public void AssertPrepareCode (ApplePlatform platform, Action<AssemblyPreparer>? configure, string code, out string outputPath)
	{
		Configuration.IgnoreIfIgnoredPlatform (platform);

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

		var assemblies = Configuration.GetReferenceAssemblies (platform);
		assemblies.Add (Path.Combine (assemblyDir, "Test.dll"));
		var infos = assemblies.Select (v => new AssemblyPreparerInfo (v, Path.Combine (assemblyDir, Path.GetFileName (v)))).ToArray ();
		var preparer = new AssemblyPreparer (infos, platform);
		if (configure is not null)
			configure (preparer);
		AssertPrepare (preparer);
		
		outputPath = Path.Combine (assemblyDir, "Test.dll");
	}
}
