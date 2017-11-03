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
		public void BI1049 ()
		{
			var bgen = new BGenTool ();
			bgen.Profile = Profile.iOS;
			bgen.CreateTemporaryBinding (File.ReadAllText (Path.Combine (Configuration.SourceRoot, "tests", "generator", "bindas1049error.cs")));
			bgen.AssertExecuteError ("build");
			bgen.AssertError (1049, "Could not unbox type String from NSNumber container used on member BindAs1049ErrorTests.MyFooClass.StringMethod decorated with [BindAs].");
		}

		[Test]
		public void BI1050_model ()
		{
			var bgen = new BGenTool ();
			bgen.Profile = Profile.iOS;
			bgen.CreateTemporaryBinding (File.ReadAllText (Path.Combine (Configuration.SourceRoot, "tests", "generator", "bindas1050modelerror.cs")));
			bgen.AssertExecuteError ("build");
			bgen.AssertError (1050, "[BindAs] cannot be used inside Protocol or Model types. Type: MyFooClass");
		}

		[Test]
		public void BI1050_protocol ()
		{
			var bgen = new BGenTool ();
			bgen.Profile = Profile.iOS;
			bgen.CreateTemporaryBinding (File.ReadAllText (Path.Combine (Configuration.SourceRoot, "tests", "generator", "bindas1050protocolerror.cs")));
			bgen.AssertExecuteError ("build");
			bgen.AssertError (1050, "[BindAs] cannot be used inside Protocol or Model types. Type: MyFooClass");
		}

		[Test]
		public void BI1060 ()
		{
			var bgen = new BGenTool ();
			bgen.Profile = Profile.iOS;
			bgen.CreateTemporaryBinding (File.ReadAllText (Path.Combine (Configuration.SourceRoot, "tests", "generator", "bug42855.cs")));
			bgen.AssertExecute ("build");
			bgen.AssertWarning (1060, "The Bug42855Tests.MyFooClass protocol is decorated with [Model], but not [BaseType]. Please verify that [Model] is relevant for this protocol; if so, add [BaseType] as well, otherwise remove [Model].");
		}

		[Test]
		public void BI1061 ()
		{
			var bgen = new BGenTool ();
			bgen.Profile = Profile.iOS;
			bgen.CreateTemporaryBinding (File.ReadAllText (Path.Combine (Configuration.SourceRoot, "tests", "generator", "bug57070.cs")));
			bgen.AssertExecuteError ("build");
			bgen.AssertWarning (1061, "The attribute 'ObjCRuntime.iOSAttribute' found on 'SomeClass.DoSomething' is not a valid binding attribute. Please remove this attribute.");
		}

		[Test]
		public void BI1117 ()
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
		public void BI1117_classinternal ()
		{
			var bgen = new BGenTool ();
			bgen.Profile = Profile.iOS;
			bgen.CreateTemporaryBinding (File.ReadAllText (Path.Combine (Configuration.SourceRoot, "tests", "generator", "bug52570classinternal.cs")));
			bgen.AssertExecute("build");
			bgen.AssertNoWarnings ();
		}

		[Test]
		public void BI1117_methodinternal ()
		{
			var bgen = new BGenTool ();
			bgen.Profile = Profile.iOS;
			bgen.CreateTemporaryBinding (File.ReadAllText (Path.Combine (Configuration.SourceRoot, "tests", "generator", "bug52570methodinternal.cs")));
			bgen.AssertExecute ("build");
			bgen.AssertNoWarnings ();
		}

		[Test]
		public void BI1117_allowstaticmembers ()
		{
			var bgen = new BGenTool ();
			bgen.Profile = Profile.iOS;
			bgen.CreateTemporaryBinding (File.ReadAllText (Path.Combine (Configuration.SourceRoot, "tests", "generator", "bug52570allowstaticmembers.cs")));
			bgen.AssertExecute ("build");
			bgen.AssertNoWarnings ();
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
