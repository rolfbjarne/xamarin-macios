using Mono.Cecil.Rocks;

namespace AssemblyPreparerTests;

public class PreserveBlockCodeHandlerTests {
	[Test]
	[TestCase (ApplePlatform.MacCatalyst)]
	[TestCase (ApplePlatform.iOS)]
	[TestCase (ApplePlatform.TVOS)]
	[TestCase (ApplePlatform.MacOSX)]
	public void First (ApplePlatform platform)
	{
		var code = @"
        using System;
        using ObjCRuntime;
        namespace ObjCRuntime;
        class Trampolines {
			static internal class SDInnerBlock {
				// this field is not preserved by other means, but it must not be linked away
				static internal readonly DInnerBlock Handler = Invoke;

				[MonoPInvokeCallback (typeof (DInnerBlock))]
				static internal void Invoke (IntPtr block, int magic_number)
				{
				}

                public delegate void DInnerBlock (IntPtr block, int magic_number);
			}
        }";

		var csproj = $@"
<Project Sdk=""Microsoft.NET.Sdk"">
	<PropertyGroup>
		<TargetFramework>net$(BundledNETCoreAppTargetFrameworkVersion)-{platform.AsString ().ToLower ()}</TargetFramework>
        <AppendTargetFrameworkToOutputPath>false</AppendTargetFrameworkToOutputPath>
        <CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>
	</PropertyGroup>
</Project>
    ";

		var tmpdir = Cache.CreateTemporaryDirectory ();
		File.WriteAllText (Path.Combine (tmpdir, "Test.cs"), code);
		var csprojPath = Path.Combine (tmpdir, "Test.csproj");
		File.WriteAllText (csprojPath, csproj);
		DotNet.AssertBuild (csprojPath);
		var assemblyDir = Path.Combine (tmpdir, "bin", "Debug");

		var assemblies = GetAssemblies (platform);
		assemblies.Add (Path.Combine (assemblyDir, "Test.dll"));
		var infos = assemblies.Select (v => new AssemblyPreparerInfo (v, Path.Combine (assemblyDir, "out", Path.GetFileName (v)))).ToArray ();
		var preparer = new AssemblyPreparer (infos, platform);
		Assert.That (preparer.Prepare (out var exceptions), Is.True, "Prepare");
		Assert.That (exceptions, Is.Empty, "Exceptions");

		var outputPath = Path.Combine (assemblyDir, "out", "Test.dll");
		var assemblyDefinition = AssemblyDefinition.ReadAssembly (outputPath);
		var type = assemblyDefinition.MainModule.Types.Single (v => v.Name == "Trampolines").NestedTypes.Single (v => v.Name == "SDInnerBlock");
		var cctor = type.GetStaticConstructor ();
		var attribs = cctor.CustomAttributes?.OrderBy (v => string.Join (", ", v.ConstructorArguments.Select (v => v.Value?.ToString ()))).ToArray ();
		Assert.That (attribs, Is.Not.Null, "Attributes");
		Assert.That (attribs.Count, Is.EqualTo (2), "Attribute count");
		Assert.That (attribs.All (v => v.AttributeType.Name == "DynamicDependencyAttribute"), Is.True, "Attribute name");
		Assert.That ((string) attribs [0].ConstructorArguments [0].Value, Is.EqualTo ("Handler"), "First attribute's first argument");
		Assert.That ((string) attribs [1].ConstructorArguments [0].Value, Is.EqualTo ("Invoke(System.IntPtr,System.Int32)"), "Second attribute's first argument");
		Assert.That (((TypeDefinition) attribs [0].ConstructorArguments [1].Value).FullName, Is.EqualTo ("ObjCRuntime.Trampolines/SDInnerBlock"), "First attribute's second argument");
		Assert.That (((TypeDefinition) attribs [1].ConstructorArguments [1].Value).FullName, Is.EqualTo ("ObjCRuntime.Trampolines/SDInnerBlock"), "Second attribute's second argument");
	}

	List<string> GetAssemblies (ApplePlatform platform)
	{
		var assemblies = new List<string> ();
		string rid;
		string packageName;
		switch (platform) {
		case ApplePlatform.MacCatalyst:
			rid = "maccatalyst-arm64";
			packageName = "microsoft.netcore.app.runtime.mono.maccatalyst-arm64";
			break;
		case ApplePlatform.iOS:
			rid = "ios-arm64";
			packageName = "microsoft.netcore.app.runtime.mono.ios-arm64";
			break;
		case ApplePlatform.TVOS:
			rid = "tvos-arm64";
			packageName = "microsoft.netcore.app.runtime.mono.tvos-arm64";
			break;
		case ApplePlatform.MacOSX:
			rid = "osx-arm64";
			packageName = "microsoft.netcore.app.runtime.osx-arm64";
			break;
		default:
			throw new NotSupportedException ($"Unsupported platform: {platform}");
		}
		var microsoftNetCoreAppRefPackageVersion = File.ReadAllLines (Path.Combine (Configuration.RootPath, "dotnet.config")).Single (v => v.StartsWith ("BUNDLED_NETCORE_PLATFORMS_PACKAGE_VERSION=", StringComparison.Ordinal)).Replace ("BUNDLED_NETCORE_PLATFORMS_PACKAGE_VERSION=", "");
		var bclDir = Path.Combine (Configuration.RootPath, "packages", packageName, microsoftNetCoreAppRefPackageVersion, "runtimes", rid, "lib", Configuration.DotNetTfm);
		var nativeDir = Path.Combine (Configuration.RootPath, "packages", packageName, microsoftNetCoreAppRefPackageVersion, "runtimes", rid, "native");

		assemblies.AddRange (Directory.GetFiles (bclDir, "*.dll"));
		assemblies.AddRange (Directory.GetFiles (nativeDir, "*.dll"));
		assemblies.Add (Path.Combine (Configuration.GetRuntimeDirectory (platform, rid), "lib", Configuration.DotNetTfm, Configuration.GetBaseLibraryName (platform)));

		return assemblies;
	}
}
