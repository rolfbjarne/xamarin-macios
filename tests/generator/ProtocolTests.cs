using System;
using System.Linq;

using NUnit.Framework;
using Xamarin.Tests;

namespace GeneratorTests {
	[TestFixture ()]
	[Parallelizable (ParallelScope.All)]
	public class ProtocolTests : BGenBase {
#if !NET
		[Ignore ("This only applies to .NET")]
#endif
		[TestCase (Profile.MacCatalyst)]
		public void OptionalMethod (Profile profile)
		{
			var bgen = BuildFile (profile, "tests/protocols.cs");

			var allTypeDefinitions = bgen.ApiAssembly.MainModule.GetTypes ().ToArray ();
			var allTypes = allTypeDefinitions.Select (v => v.FullName).ToArray ();
			Assert.That (allTypes, Does.Contain ("Protocols.RequiredProtocolCompatWithExtensions_Extensions"), "Compat extensions");
		}
	}
}

