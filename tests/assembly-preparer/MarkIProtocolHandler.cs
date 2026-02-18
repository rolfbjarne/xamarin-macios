using Mono.Cecil.Rocks;

namespace AssemblyPreparerTests;

public class MarkIProtocolHandlerTests : BaseClass {
	[Test]
	[TestCase (ApplePlatform.MacCatalyst)]
	[TestCase (ApplePlatform.iOS)]
	[TestCase (ApplePlatform.TVOS)]
	[TestCase (ApplePlatform.MacOSX)]
	public void DynamicRegistrar (ApplePlatform platform)
	{
		var code = @"
		using System;
		using Foundation;
		using ObjCRuntime;

		[Protocol]
		interface IProtocol {
		}

		class MyClass : NSObject, IProtocol {
		}
		";

		AssertPrepare (platform, RegistrarMode.Dynamic, code, out var assemblyDefinition);

		var type = assemblyDefinition.MainModule.Types.Single (v => v.Name == "MyClass");
		var cctor = type.GetStaticConstructor ();
		var attribs = cctor.CustomAttributes?.OrderBy (v => string.Join (", ", v.ConstructorArguments.Select (v => v.Value?.ToString ()))).ToArray ();
		Assert.That (attribs, Is.Not.Null, "Attributes");
		Assert.That (attribs.Count, Is.EqualTo (1), "Attribute count");
		Assert.That (attribs.All (v => v.AttributeType.Name == "DynamicDependencyAttribute"), Is.True, "Attribute name");
		Assert.That ((string) attribs [0].ConstructorArguments [0].Value, Is.EqualTo ("IProtocol"), "First attribute's first argument");
		Assert.That (((TypeDefinition) attribs [0].ConstructorArguments [1].Value).FullName, Is.EqualTo ("MyClass"), "First attribute's second argument");
	}

	[Test]
	[TestCase (ApplePlatform.MacCatalyst)]
	[TestCase (ApplePlatform.iOS)]
	[TestCase (ApplePlatform.TVOS)]
	[TestCase (ApplePlatform.MacOSX)]
	public void ManagedStaticRegistrar (ApplePlatform platform)
	{
		var code = @"
		using System;
		using Foundation;
		using ObjCRuntime;

		[Protocol]
		interface IProtocol {
		}

		class MyClass : NSObject, IProtocol {
		}
		";

		var modified = AssertPrepareCode (platform, preparer => preparer.Registrar = RegistrarMode.ManagedStatic, code, out var _);
		Assert.That (modified, Is.False, "Assembly should not be modified");
	}
}
