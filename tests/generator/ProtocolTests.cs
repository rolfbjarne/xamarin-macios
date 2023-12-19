using System;

using NUnit.Framework;
using Xamarin.Tests;

namespace GeneratorTests {
	[TestFixture ()]
	[Parallelizable (ParallelScope.All)]
	public class ProtocolTests : BGenBase
	{
		[TestCase (Profile.MacCatalyst)]
		public void OptionalMethod (Profile profile)
		{
			BuildFile (profile, "tests/protocols.cs");
		}
	}
}

