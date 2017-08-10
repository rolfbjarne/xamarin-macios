using System;

using NUnit.Framework;
using Mono.Cecil;

using Xamarin.Tests;

namespace GeneratorTests
{
	[TestFixture ()]
	[Parallelizable (ParallelScope.All)]
	public class ProtocolTests
	{
		[Test]
		public void ProtocolWithConstructor ()
		{
			var bgen = new BGenTool ();
			var api_definition = @"
using System;

using Foundation;
using ObjCRuntime;

namespace ApiDefinition
{
	[Protocol]
	interface ProtocolWithConstructor
	{
		[Abstract]
		[Export (""initWithTestParameter:"")]
		IntPtr Constructor (string parameter);
	}

	// Inline the protocol in a class.
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SomeClass : ProtocolWithConstructor {}


	// Inline the protocol in a class.
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SomeClass2 : ProtocolWithConstructor {
		[Export (""initWithTestParameter:"")]
		IntPtr Constructor (string parameter);
	}
}
";
			bgen.CreateTemporaryBinding (api_definition);
			bgen.Profile = Profile.iOS;
			bgen.AssertExecute ("build");
			bgen.AssertPublicTypeCount (2);
			bgen.AssertType ("ApiDefinition.IProtocolWithConstructor", TypeAttributes.Public | TypeAttributes.Interface | TypeAttributes.Abstract);
			bgen.AssertPublicMethodCount ("ApiDefinition.IProtocolWithConstructor", 0);
			bgen.AssertType ("ApiDefinition.SomeClass", TypeAttributes.Public | TypeAttributes.BeforeFieldInit);
			bgen.AssertPublicMethodCount ("ApiDefinition.SomeClass", 3);
			bgen.AssertMethod ("ApiDefinition.SomeClass", ".ctor", parameterTypes: new string [] { "System.String" });
		}


		[Test]
		public void ProtocolWithConstructor2 ()
		{
			var bgen = new BGenTool ();
			var api_definition = @"
using System;

using Foundation;
using ObjCRuntime;

namespace ApiDefinition
{
	[Protocol]
	interface ProtocolWithConstructor
	{
		[Abstract]
		[Export (""initWithTestParameter:"")]
		IntPtr Constructor (string parameter);
	}
}
";
			bgen.CreateTemporaryBinding (api_definition);
			bgen.Profile = Profile.iOS;
			bgen.AssertExecute ("build");
			bgen.AssertPublicTypeCount (2);
			bgen.AssertType ("ApiDefinition.IProtocolWithConstructor", TypeAttributes.Public | TypeAttributes.Interface | TypeAttributes.Abstract);
			bgen.AssertPublicMethodCount ("ApiDefinition.IProtocolWithConstructor", 0);
			bgen.AssertType ("ApiDefinition.ProtocolWithConstructor_Extensions", TypeAttributes.Public | TypeAttributes.BeforeFieldInit | TypeAttributes.Sealed | TypeAttributes.Abstract);
			bgen.AssertPublicMethodCount ("ApiDefinition.ProtocolWithConstructor_Extensions", 1);
			bgen.AssertMethod ("ApiDefinition.ProtocolWithConstructor_Extensions", "CreateInstance", parameterTypes: new string [] { "System.Type", "System.String" });
		}
	}
}
