using System;
using System.IO;
using NUnit.Framework;

using Xamarin.Tests;

namespace GeneratorTests
{
	[TestFixture ()]
	[Parallelizable (ParallelScope.All)]
	public class ErrorTests
	{
		[Test]
		public void BI0086 ()
		{
			var bgen = new BGenTool ();
			bgen.CreateTemporaryBinding ("");
			bgen.AssertExecuteError ("build");
			bgen.AssertError (86, "A target framework (--target-framework) must be specified.");
		}

		[Test]
		public void BI1048 ()
		{
			var bgen = new BGenTool ();
			bgen.Profile = Profile.iOS;
			bgen.CreateTemporaryBinding (File.ReadAllText (Path.Combine (Configuration.SourceRoot, "tests", "generator", "bindas1048error.cs")));
			bgen.AssertExecuteError ("build");
			bgen.AssertError (1048, "Unsupported type String decorated with [BindAs]");
		}

		[Test]
		public void BI1061 ()
		{
			var bgen = new BGenTool ();
			bgen.Profile = Profile.iOS;
			bgen.CreateTemporaryBinding (@"using System;
using Foundation;

namespace Bug52570Tests {

	[Category]
	[BaseType (typeof (FooObject))]
	interface FooObject_Extensions {

		[Static]
		[Export (""someMethod:"")]
		bool SomeMethod (NSRange range);
	}

	[BaseType (typeof (NSObject))]
	interface FooObject {
	
	}
}");
			bgen.AssertExecute ("build");
			bgen.AssertWarning (1117, "The SomeMethod member is decorated with [Static] and its container class Bug52570Tests.FooObject_Extensions is decorated with [Category] this leads to hard to use code. Please inline SomeMethod into Bug52570Tests.FooObject class.");
		}

		[Test]
		public void BindAsNoMultidimensionalArrays ()
		{
			var bgen = new BGenTool ();
			bgen.Profile = Profile.iOS;
			bgen.CreateTemporaryBinding (@"
using System;
using Foundation;
using AVFoundation;
using ObjCRuntime;

namespace Bug57795Tests {

	[BaseType (typeof (NSObject))]
	interface FooObject {

		[BindAs (typeof (AVMediaTypes [,]))]
		[Export (""strongAVMediaTypesPropertiesMulti:"")]
		NSString [,] StrongAVMediaTypesPropertiesMulti { get; set; }
	}
}");
			bgen.AssertExecuteError ("build");
			bgen.AssertError (1048, "Unsupported type AVMediaTypes[,] decorated with [BindAs]");
		}
	}
}
