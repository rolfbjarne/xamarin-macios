using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Xml;

using NUnit.Framework;

[TestFixture]
public abstract class SampleTester
{
	public string Repository { get; private set; }

	Dictionary<string, string> ignored_solutions;
	Dictionary<string, string> GetIgnoredSolutions ()
	{
		if (ignored_solutions == null)
			ignored_solutions = GetIgnoredSolutionsImpl ();
		return ignored_solutions;
	}

	protected virtual Dictionary<string, string> GetIgnoredSolutionsImpl ()
	{
		return new Dictionary<string, string> ();
	}

	protected SampleTester (string repo)
	{
		Repository = repo;
	}

	protected static void AssertRunProcess (string filename, string arguments, TimeSpan timeout, string workingDirectory, string message)
	{
		var exitCode = 0;

		Assert.IsTrue (RunProcess (filename, arguments, out exitCode, timeout, workingDirectory), $"{message} timed out after {timeout.TotalMinutes} minutes");
		Assert.AreEqual (0, exitCode, $"{message} failed (unexpected exit code)");
	}

	// runs the process and doesn't care about the result.
	protected static void RunProcess (string filename, string arguments, TimeSpan timeout, string workingDirectory)
	{
		int exitCode;
		RunProcess (filename, arguments, out exitCode, timeout, workingDirectory);
	}

	// returns false if timed out (in which case exit code is int.MinValue
	protected static bool RunProcess (string filename, string arguments, out int exitCode, TimeSpan timeout, string workingDirectory)
	{	
		var outputDone = new ManualResetEvent (false);
		var errorDone = new ManualResetEvent (false);
		using (var xbuild = new Process ()) {
			xbuild.StartInfo.FileName = filename;
			xbuild.StartInfo.Arguments = arguments;
			xbuild.StartInfo.RedirectStandardError = true;
			xbuild.StartInfo.RedirectStandardOutput = true;
			xbuild.StartInfo.UseShellExecute = false;
			xbuild.StartInfo.WorkingDirectory = workingDirectory;
			xbuild.OutputDataReceived += (sender, e) =>
			{
				if (e.Data == null) {
					outputDone.Set ();
				} else {
					Console.WriteLine (e.Data);
				}
			};
			xbuild.ErrorDataReceived += (sender, e) =>
			{
				if (e.Data == null) {
					errorDone.Set ();
				} else {
					Console.WriteLine (e.Data);
				}
			};
			Console.WriteLine ("{0} {1}", xbuild.StartInfo.FileName, xbuild.StartInfo.Arguments);
			xbuild.Start ();
			xbuild.BeginErrorReadLine ();
			xbuild.BeginOutputReadLine ();
			var rv = xbuild.WaitForExit ((int) timeout.TotalMilliseconds);
			if (rv) {
				outputDone.WaitOne (TimeSpan.FromSeconds (5));
				errorDone.WaitOne (TimeSpan.FromSeconds (5));
				exitCode = xbuild.ExitCode;
			} else {
				Console.WriteLine ("Command timed out after {0}s", timeout.TotalSeconds);
				exitCode = int.MinValue;
			}
			return rv;
		}
	}

	void BuildSolution (string solution, string msbuild, string platform, string configuration)
	{
		string ignored_message = "Ignored";
		if (GetIgnoredSolutions ()?.TryGetValue (solution, out ignored_message) == true)
			Assert.Ignore (ignored_message);

		solution = Path.Combine (CloneRepo (), solution);

		try {
			AssertRunProcess ("nuget", $"restore \"{solution}\"", TimeSpan.FromMinutes (2), RootDirectory, "nuget restore");
			AssertRunProcess (msbuild, $"/verbosity:diag /p:Platform={platform} /p:Configuration={configuration} \"{solution}\"", TimeSpan.FromMinutes (5), RootDirectory, "build");
		} finally {
			// Clean up after us, since building for device needs a lot of space.
			// Ignore any failures (since failures here doesn't mean the test failed).
			RunProcess ("git", "clean -xfdq", TimeSpan.FromSeconds (30), Path.GetDirectoryName (solution));
		}
	}

	[TestCaseSource ("GetSolutions")]
	public void BuildSolution (string solution)
	{
		BuildSolution (solution, "xbuild", "iPhone", "Debug");
	}

	protected static string RootDirectory {
		get {
			// I'd like to clone the samples into a subdirectory that will be cleaned on the bots,
			// but using a subdirectory in xamarin-macios makes nuget-dependending projects pick
			// up xamarin-macios' Nuget.Config, which sets the repository path, and the nugets are
			// restored to location the projects don't expect.
			// So instead clone the sample repositories into /tmp
			//return Path.Combine (Path.GetDirectoryName (System.Reflection.Assembly.GetExecutingAssembly ().Location), "repositories");
			return Path.Combine ("/tmp/xamarin-macios-sample-builder/repositories");
		}
	}

	protected static string [] GetSolutionsImpl (string repo)
	{
		var fn = Path.Combine (RootDirectory, $"{repo}.filelist");
		if (File.Exists (fn))
			return File.ReadAllLines (fn);
		Directory.CreateDirectory (Path.GetDirectoryName (fn));

		using (var client = new WebClient ()) {
			byte [] data;
			try {
				client.Headers.Add (HttpRequestHeader.UserAgent, "xamarin");
				data = client.DownloadData ($"https://api.github.com/repos/xamarin/{repo}/git/trees/master?recursive=1");
			} catch (WebException we) {
				return new string [] { $"Failed to load repo: {we.Message}" };
			}
			var reader = JsonReaderWriterFactory.CreateJsonReader (data, new XmlDictionaryReaderQuotas ());
			var doc = new XmlDocument ();
			doc.Load (reader);
			var rv = new List<string> ();
			foreach (XmlNode node in doc.SelectNodes ("/root/tree/item/path")) {
				var path = node.InnerText;
				if (!path.EndsWith (".sln", StringComparison.OrdinalIgnoreCase))
					continue;
				rv.Add (node.InnerText);
			}

			File.WriteAllLines (fn, rv.ToArray ());
			return rv.ToArray ();
		}
	}

	string CloneRepo ()
	{
		var repo_dir = Path.Combine (RootDirectory, Path.GetFileName (Repository));

		Directory.CreateDirectory (RootDirectory);

		if (!Directory.Exists (repo_dir)) {
			var exitCode = 0;
			Assert.IsTrue (RunProcess ("git", $"clone git@github.com:xamarin/{Repository}", out exitCode, TimeSpan.FromMinutes (10), RootDirectory), "cloned in 10 minutes");
			Assert.AreEqual (0, exitCode, "git clone exit code");
		}

		return repo_dir;
	}
}

[Ignore ("skip while configuring")]
public class IosSampleTester : SampleTester
{
	const string REPO = "ios-samples"; // monotouch-samples redirects to ios-samples
	public IosSampleTester ()
		: base (REPO)
	{
	}

	static string [] GetSolutions ()
	{
		return GetSolutionsImpl (REPO);
	}

	protected override Dictionary<string, string> GetIgnoredSolutionsImpl ()
	{
		return new Dictionary<string, string> {
			{ "BindingSample/src/sample/Xamarin.XMBindingLibrarySample/Xamarin.XMBindingLibrarySample.sln", "Binding sample solution that depends on a makefile-built binding library. Fix: change the makefile-built binding library to a binding project, and add it as a project reference in the solution" },
			{ "BouncingGameEmptyiOS/BouncingGame.sln", @"nuget restore fails with: Unable to find version '1.3.1.0' of package 'CocosSharp.PCL.Shared'." },
			{ "CustomTransitions/CustomTransitions.sln", "personal code signing key: /Library/Frameworks/Mono.framework/External/xbuild/Xamarin/iOS/Xamarin.iOS.Common.targets: error : iOS code signing key 'iPhone Developer: Germán Marquez (U3F86JM574)' not found in keychain." },
			{ "CustomTransitions/CustomTransitions/CustomTransitions.sln", "personal code signing key: /Library/Frameworks/Mono.framework/External/xbuild/Xamarin/iOS/Xamarin.iOS.Common.targets: error : iOS code signing key 'iPhone Developer: Germán Marquez (U3F86JM574)' not found in keychain." },
			{ "FileSystemSampleCode/WorkingWithTheFileSystem.sln", @"nuget restore fails with: Unable to find version '7.0.1' of package 'Newtonsoft.Json'." },
			{ "Location/Location.sln",
				@"nuget restore fails with: 
	Unable to find version '0.13.0' of package 'Xamarin.TestCloud.Agent'.
	Unable to find version '2.6.3' of package 'NUnit'.
	Unable to find version '0.7.1' of package 'Xamarin.UITest'."
			},
			{ "Profiling/MemoryDemo/MemoryDemo.sln", @"build fails with: /private/tmp/xamarin-macios-sample-builder/repositories/ios-samples/Profiling/MemoryDemo/MemoryDemo.sln: error : Invalid solution configuration and platform: ""Debug|iPhone""." },
			{ "PassKit/PassLibrary/PassLibrary.sln", @"build fails with: /Library/Frameworks/Mono.framework/External/xbuild/Xamarin/iOS/Xamarin.iOS.Common.targets: error :   Bundle Resource 'CouponBanana2.pkpass' not found on disk (should be at '/private/tmp/xamarin-macios-sample-builder/repositories/ios-samples/PassKit/PassLibrary/CouponBanana2.pkpass') " },
			{ "WalkingGameCompleteiOS/WalkingGame.sln",
				@"nuget restore fails with:
	Unable to find version '3.5.1.1679' of package 'MonoGame.Framework.iOS'.
	Unable to find version '3.2.99.1-Beta' of package 'MonoGame.Framework.Portable'."
			},
			{ "WalkingGameEmptyiOS/WalkingGame.sln",
				@"nuget restore fails with:
	Unable to find version '3.5.1.1679' of package 'MonoGame.Framework.iOS'.
	Unable to find version '3.2.99.1-Beta' of package 'MonoGame.Framework.Portable'."
			},
			{ "WatchKit/WatchKitCatalog/WatchKitCatalog.sln", @"nuget restore fails with: Unable to find version '6.0.6' of package 'Newtonsoft.Json'." },
			{ "WorkingWithTables/Part 3 - Customizing a Table's appearance/1 - CellDefaultTable/CellDefaultTable.sln",
				@"build fails with:
	/tmp/xamarin-macios-sample-builder/repositories/ios-samples/WorkingWithTables/Part 3 - Customizing a Table's appearance/1 - CellDefaultTable/CellDefaultTable.sln: error : Unable to parse condition ""Exists ('/tmp/xamarin-macios-sample-builder/repositories/ios-samples/WorkingWithTables/Part 3 - Customizing a Table's appearance/1 - CellDefaultTable/before.CellDefaultTable.sln.targets')"" : Invalid punctuation: /
	/tmp/xamarin-macios-sample-builder/repositories/ios-samples/WorkingWithTables/Part 3 - Customizing a Table's appearance/1 - CellDefaultTable/CellDefaultTable.sln: Microsoft.Build.BuildEngine.InvalidProjectFileException: Unable to parse condition ""Exists ('/tmp/xamarin-macios-sample-builder/repositories/ios-samples/WorkingWithTables/Part 3 - Customizing a Table's appearance/1 - CellDefaultTable/before.CellDefaultTable.sln.targets')"" : Invalid punctuation: / ---> Microsoft.Build.BuildEngine.ExpressionParseException: Invalid punctuation: /
	  at Microsoft.Build.BuildEngine.ConditionTokenizer.GetNextToken () [0x0040e] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseFunctionArguments () [0x00006] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseFunctionExpression (System.String function_name) [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseFactorExpression () [0x00067] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseRelationalExpression () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseBooleanOr () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseBooleanAnd () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseBooleanExpression () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseExpression () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseCondition (System.String condition) [0x00007] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseAndEvaluate (System.String condition, Microsoft.Build.BuildEngine.Project context) [0x0000d] in <be39fd865fc6443ba8e0754f0d58cf2f>:0"
			},
			{ "WorkingWithTables/Part 3 - Customizing a Table's appearance/2 - CellAccessoryTable/CellAccessoryTable.sln",
				@"build fails with:
	/tmp/xamarin-macios-sample-builder/repositories/ios-samples/WorkingWithTables/Part 3 - Customizing a Table's appearance/2 - CellAccessoryTable/CellAccessoryTable.sln: error : Unable to parse condition ""Exists ('/tmp/xamarin-macios-sample-builder/repositories/ios-samples/WorkingWithTables/Part 3 - Customizing a Table's appearance/2 - CellAccessoryTable/before.CellAccessoryTable.sln.targets')"" : Invalid punctuation: /
	/tmp/xamarin-macios-sample-builder/repositories/ios-samples/WorkingWithTables/Part 3 - Customizing a Table's appearance/2 - CellAccessoryTable/CellAccessoryTable.sln: Microsoft.Build.BuildEngine.InvalidProjectFileException: Unable to parse condition ""Exists ('/tmp/xamarin-macios-sample-builder/repositories/ios-samples/WorkingWithTables/Part 3 - Customizing a Table's appearance/2 - CellAccessoryTable/before.CellAccessoryTable.sln.targets')"" : Invalid punctuation: / ---> Microsoft.Build.BuildEngine.ExpressionParseException: Invalid punctuation: /
	  at Microsoft.Build.BuildEngine.ConditionTokenizer.GetNextToken () [0x0040e] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseFunctionArguments () [0x00006] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseFunctionExpression (System.String function_name) [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseFactorExpression () [0x00067] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseRelationalExpression () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseBooleanOr () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseBooleanAnd () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseBooleanExpression () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseExpression () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseCondition (System.String condition) [0x00007] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseAndEvaluate (System.String condition, Microsoft.Build.BuildEngine.Project context) [0x0000d] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 "
			},
			{ "WorkingWithTables/Part 3 - Customizing a Table's appearance/3 - CellCustomTable/CellCustomTable.sln",
				@"build fails with:
	/tmp/xamarin-macios-sample-builder/repositories/ios-samples/WorkingWithTables/Part 3 - Customizing a Table's appearance/3 - CellCustomTable/CellCustomTable.sln: error : Unable to parse condition ""Exists ('/tmp/xamarin-macios-sample-builder/repositories/ios-samples/WorkingWithTables/Part 3 - Customizing a Table's appearance/3 - CellCustomTable/before.CellCustomTable.sln.targets')"" : Invalid punctuation: /
	/tmp/xamarin-macios-sample-builder/repositories/ios-samples/WorkingWithTables/Part 3 - Customizing a Table's appearance/3 - CellCustomTable/CellCustomTable.sln: Microsoft.Build.BuildEngine.InvalidProjectFileException: Unable to parse condition ""Exists ('/tmp/xamarin-macios-sample-builder/repositories/ios-samples/WorkingWithTables/Part 3 - Customizing a Table's appearance/3 - CellCustomTable/before.CellCustomTable.sln.targets')"" : Invalid punctuation: / ---> Microsoft.Build.BuildEngine.ExpressionParseException: Invalid punctuation: /
	  at Microsoft.Build.BuildEngine.ConditionTokenizer.GetNextToken () [0x0040e] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseFunctionArguments () [0x00006] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseFunctionExpression (System.String function_name) [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseFactorExpression () [0x00067] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseRelationalExpression () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseBooleanOr () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseBooleanAnd () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseBooleanExpression () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseExpression () [0x00000] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseCondition (System.String condition) [0x00007] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 
	  at Microsoft.Build.BuildEngine.ConditionParser.ParseAndEvaluate (System.String condition, Microsoft.Build.BuildEngine.Project context) [0x0000d] in <be39fd865fc6443ba8e0754f0d58cf2f>:0 "
			},
			{ "ios10/ElizaChat/ElizaChat.sln", "personal code signing key: /Library/Frameworks/Mono.framework/External/xbuild/Xamarin/iOS/Xamarin.iOS.Common.targets: error : iOS code signing key 'iPhone Developer: Kevin Mullins (46FB3Q72SJ)' not found in keychain." },
			{ "ios10/IceCreamBuilder/IceCreamBuilder.sln", @"nuget restore fails with: Unable to find version '9.0.1' of package 'Newtonsoft.Json'." },
			{ "ios9/MultiTask/MultiTask.sln", "personal code signing key: /Library/Frameworks/Mono.framework/External/xbuild/Xamarin/iOS/Xamarin.iOS.Common.targets: error : iOS code signing key 'iPhone Developer: Kevin Mullins (46FB3Q72SJ)' not found in keychain." },
			{ "ios9/iTravel/iTravel.sln", @"nuget restore fails with: Unable to find version '8.0.2' of package 'Newtonsoft.Json'." },
			{ "watchOS/WatchConnectivity/WatchConnectivity.sln", @"nuget restore fails with: Unable to find version '9.0.1' of package 'Newtonsoft.Json'." },
			{ "watchOS/WatchKitCatalog/WatchKitCatalog.sln", @"nuget restore fails with: Unable to find version '9.0.1' of package 'Newtonsoft.Json'." },
		};
	}
}

public class MacIosSampleTester : SampleTester
{
	const string REPO = "mac-ios-samples";
	public MacIosSampleTester ()
		: base (REPO)
	{
	}

	static string [] GetSolutions ()
	{
		return GetSolutionsImpl (REPO);
	}

	protected override Dictionary<string, string> GetIgnoredSolutionsImpl ()
	{
		return new Dictionary<string, string>
		{
			{  "AgentsCatalog/AgentsCatalog.sln", "build error: /Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Mac/Xamarin.Mac.Common.targets: error : Error executing task ACTool: Method 'Xamarin.MacDev.PObject.Save' not found." },
			{ "SceneKitReel/SceneKitReel.sln",
				@"Compile errors: 
xamarin-macios/tests/sampletester/bin/Debug/repositories/mac-ios-samples/SceneKitReel/SceneKitReelShared/GameViewController.cs(1072,4): error CS0103: The name `p3d' does not exist in the current context
xamarin-macios/tests/sampletester/bin/Debug/repositories/mac-ios-samples/SceneKitReel/SceneKitReelShared/GameViewController.cs(1081,26): error CS0103: The name `p3d' does not exist in the current context"
			},
			{ "MetalKitEssentials/MetalKitEssentials.sln", "build error: /Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Mac/Xamarin.Mac.Common.targets: error : Error executing task ACTool: Method 'Xamarin.MacDev.PObject.Save' not found." },
		};
	}
}

[Ignore ("skip while configuring")]
public class MobileSampleTester : SampleTester
{
	const string REPO = "mobile-samples";
	public MobileSampleTester ()
		: base (REPO)
	{
	}

	static string [] GetSolutions ()
	{
		return GetSolutionsImpl (REPO);
	}

protected override Dictionary<string, string> GetIgnoredSolutionsImpl ()
	{
		return new Dictionary<string, string>
		{
			{ "AnalogClock/AnalogClock.sln", "Contains android project(s) (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "AsyncAwait/AsyncAwait.sln", "Contains android project(s) (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "AsyncAwait/Windows/Windows.sln", "build fails with: /tmp/xamarin-macios-sample-builder/repositories/mobile-samples/AsyncAwait/Windows/Windows.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\"." },
			{ "Azure/GetStartedWithData/Android/XamarinTodoQuickStart.Android.sln", "Contains android project(s)" },
			{ "Azure/GetStartedWithData/iOS/XamarinTodoQuickStart.iOS.sln",
				@"build fails with:
	TodoItem.cs(2,7): error CS0246: The type or namespace name `Newtonsoft' could not be found. Are you missing an assembly reference?
	TodoService.cs(9,18): error CS0234: The type or namespace name `WindowsAzure' does not exist in the namespace `Microsoft'. Are you missing an assembly reference?
	TodoService.cs (20,17): error CS0246: The type or namespace name `MobileServiceClient' could not be found. Are you missing an assembly reference?
	TodoService.cs(21,17): error CS0246: The type or namespace name `IMobileServiceTable' could not be found. Are you missing an assembly reference?"
			},
			{ "Azure/GetStartedWithPush/Android/XamarinTodoQuickStart.Android.sln", "Contains android project(s) (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Azure/GetStartedWithPush/Android/XamarinTodoQuickStart.Android.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Azure/GetStartedWithPush/iOS/XamarinTodoQuickStart.iOS.sln",
				@"build fails with:
	TodoItem.cs(2,7): error CS0246: The type or namespace name `Newtonsoft' could not be found. Are you missing an assembly reference?
	TodoService.cs(5,17): error CS0234: The type or namespace name `WindowsAzure' does not exist in the namespace `Microsoft'. Are you missing an assembly reference?
	TodoService.cs (15,17): error CS0246: The type or namespace name `MobileServiceClient' could not be found. Are you missing an assembly reference?
	TodoService.cs(16,17): error CS0246: The type or namespace name `IMobileServiceTable' could not be found. Are you missing an assembly reference?"
			},
			{ "Azure/GetStartedWithUsers/Android/XamarinTodoQuickStart.Android.sln", "Contains android project(s) (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Azure/GetStartedWithUsers/Android/XamarinTodoQuickStart.Android.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Azure/GetStartedWithUsers/iOS/XamarinTodoQuickStart.iOS.sln",
				@"build fails with:
	TodoItem.cs(2,7): error CS0246: The type or namespace name `Newtonsoft' could not be found. Are you missing an assembly reference?
	TodoService.cs(5,17): error CS0234: The type or namespace name `WindowsAzure' does not exist in the namespace `Microsoft'. Are you missing an assembly reference?
	TodoService.cs (16,17): error CS0246: The type or namespace name `MobileServiceClient' could not be found. Are you missing an assembly reference?
	TodoService.cs(17,17): error CS0246: The type or namespace name `MobileServiceUser' could not be found. Are you missing an assembly reference?
	TodoService.cs(18,17): error CS0246: The type or namespace name `IMobileServiceTable' could not be found. Are you missing an assembly reference?
	TodoService.cs(20,16): error CS0246: The type or namespace name `MobileServiceUser' could not be found. Are you missing an assembly reference?"
			},
			{ "Azure/GettingStarted/Android/XamarinTodoQuickStart.Android.sln", "Contains android project(s) (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Azure/GettingStarted/Android/XamarinTodoQuickStart.Android.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Azure/GettingStarted/iOS/XamarinTodoQuickStart.iOS.sln",
				@"build fails with:
	TodoItem.cs(2,7): error CS0246: The type or namespace name `Newtonsoft' could not be found. Are you missing an assembly reference?
	TodoService.cs(5,17): error CS0234: The type or namespace name `WindowsAzure' does not exist in the namespace `Microsoft'. Are you missing an assembly reference?
	TodoService.cs (14,17): error CS0246: The type or namespace name `MobileServiceClient' could not be found. Are you missing an assembly reference?
	TodoService.cs(15,17): error CS0246: The type or namespace name `IMobileServiceTable' could not be found. Are you missing an assembly reference?"
			},
			{ "Azure/NotificationHubs/Android/XamarinTodoQuickStart.Android.sln", "Contains android project(s) (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Azure/NotificationHubs/Android/XamarinTodoQuickStart.Android.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Azure/NotificationHubs/iOS/NotificationHubQuickStart.sln",
				@"build fails with:
	AppDelegate.cs(6,7): error CS0246: The type or namespace name `WindowsAzure' could not be found. Are you missing an assembly reference?
	AppDelegate.cs(16,17): error CS0246: The type or namespace name `SBNotificationHub' could not be found. Are you missing an assembly reference?"
			},
			{ "Azure/ValidateModifyData/Android/XamarinTodoQuickStart.Android.sln", "Contains android project(s) (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Azure/ValidateModifyData/Android/XamarinTodoQuickStart.Android.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Azure/ValidateModifyData/iOS/XamarinTodoQuickStart.iOS.sln",
				@"build fails with:
	TodoItem.cs(2,7): error CS0246: The type or namespace name `Newtonsoft' could not be found. Are you missing an assembly reference?
	TodoService.cs(5,17): error CS0234: The type or namespace name `WindowsAzure' does not exist in the namespace `Microsoft'. Are you missing an assembly reference?
	TodoService.cs (15,17): error CS0246: The type or namespace name `MobileServiceClient' could not be found. Are you missing an assembly reference?
	TodoService.cs(16,17): error CS0246: The type or namespace name `IMobileServiceTable' could not be found. Are you missing an assembly reference?"
			},
			{ "BackgroundLocationDemo/BackgroundLocationDemo.sln", "Contains android project(s) (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "BackgroundLocationDemo/location.Android/location.Droid.sln", "Contains android project(s) (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/BackgroundLocationDemo/location.Android/location.Droid.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "BluetoothLEExplorer/BluetoothLEExplorer.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "BluetoothLEExplorer/Components/mbprogresshud-0.8/samples/MBProgressHUDDemo/MBProgressHUDDemo.sln", "build error: /tmp/xamarin-macios-sample-builder/repositories/mobile-samples/BluetoothLEExplorer/Components/mbprogresshud-0.8/samples/MBProgressHUDDemo/MBProgressHUDDemo/MBProgressHUDDemo.csproj: error : Target named 'Build' not found in the project." },
			{ "BluetoothLEExplorer/Components/mbprogresshud-0.9.0/samples/MBProgressHUDDemo-classic/MBProgressHUDDemo-classic.sln", "XI/Classic, must be ported to XI/Unified" },
			{ "BluetoothLEExplorer/Components/mbprogresshud-0.9.0/samples/MBProgressHUDDemo/MBProgressHUDDemo.sln",
				@"build errors:
	AppDelegate.cs(400,24): error CS0115: `MBProgressHUDDemo.MyNSUrlConnectionDelegete.ReceivedResponse(Foundation.NSUrlConnection, Foundation.NSUrlResponse)' is marked as an override but no suitable method found to override
	AppDelegate.cs(407,24): error CS0115: `MBProgressHUDDemo.MyNSUrlConnectionDelegete.ReceivedData(Foundation.NSUrlConnection, Foundation.NSData)' is marked as an override but no suitable method found to override
	AppDelegate.cs(413,24): error CS0115: `MBProgressHUDDemo.MyNSUrlConnectionDelegete.FinishedLoading(Foundation.NSUrlConnection)' is marked as an override but no suitable method found to override"
			},
			{ "BouncingGame/BouncingGame.sln", "nuget restore failed: Unable to find version '1.7.1.0' of package 'CocosSharp'." },
			{ "CCAction/ActionProject.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "CCAudioEngine/CCAudioEngineSample.sln", "nuget restore: Unable to find version '1.7.1.0' of package 'CocosSharp'." },
			{ "CCDrawNode/CustomRendering.sln", "nuget restore failed: Unable to find version '1.5.0.1' of package 'CocosSharp.PCL.Shared'." },
			{ "CCRenderTexture/RenderTextureExample.sln", "nuget restore failed: Unable to find version '1.7.1.0' of package 'CocosSharp'." },
			{ "Camera/Camera.sln", "build error: MainViewController.cs(8,7): error CS0246: The type or namespace name `Xamarin' could not be found. Are you missing an assembly reference?" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/ContactsSample/ContactsSample.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/ContactsSample/ContactsSample.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/GeolocationSample/GeolocationSample.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/GeolocationSample/GeolocationSample.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/MediaPickerSample/MediaPickerSample.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/MediaPickerSample/MediaPickerSample.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/Xamarin.Mobile.Android.Samples.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/Xamarin.Mobile.Android.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.WP.Samples/Xamarin.Mobile.WP.Samples.sln", "wp (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.WP.Samples/Xamarin.Mobile.WP.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.WP8.Samples/Xamarin.Mobile.WP8.Samples.sln", "wp8 (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.WP8.Samples/Xamarin.Mobile.WP8.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.WinRT.Samples/Xamarin.Mobile.WinRT.Samples.sln", "winrt (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.WinRT.Samples/Xamarin.Mobile.WinRT.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.iOS.Samples/Xamarin.Mobile.iOS.Samples.sln", "XI/Classic, must be ported to XI/Unified" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.iOS.Samples/Geolocation/GeolocationSample.sln", "build error: /tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.iOS.Samples/Geolocation/GeolocationSample.sln: error : Could not find the project file '/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.iOS.Samples/Geolocation/GeolocationSample.csproj'" },
			{ "CameraMovement3DMG/MonoGame3D.sln",
				@"nuget restore failed:
	Unable to find version '3.5.1.1679' of package 'MonoGame.Framework.iOS'.
	Unable to find version '3.3.0.0' of package 'MonoGame.Framework.Android'."
			},
			{ "CoinTime/CoinTime.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "ContentControls/AndroidContentControls/AndroidContentControls.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/ContentControls/AndroidContentControls/AndroidContentControls.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "ContentControls/ContentControls.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "DataAccess/Advanced/DataAccess_Adv.sln",
				@"nuget restore failed:
	Unable to find version '1.1.1' of package 'sqlite-net-pcl'.
	Unable to find version '0.8.6' of package 'SQLitePCL.raw'."
			},
			{ "DataAccess/Basic/DataAccess_Basic.sln",
				@"nuget restore failed:
	Unable to find version '1.1.1' of package 'sqlite-net-pcl'.
	Unable to find version '0.8.6' of package 'SQLitePCL.raw'."
			},
			{ "DataAccess/Basic/iOS/DataAccess_Basic.sln",
				@"nuget restore failed:
	Unable to find version '1.1.1' of package 'sqlite-net-pcl'.
	Unable to find version '0.8.6' of package 'SQLitePCL.raw'."
			},
			{ "EmbeddedResources/EmbeddedResources.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "FruityFalls/FruityFalls.sln", "nuget restore failed: Unable to find version '1.7.1.0' of package 'CocosSharp'." },
			{ "GLKeysES30/GLKeysES30.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "ModelRenderingMG/MonoGame3D.sln",
				@"nuget restore failed:
	Unable to find version '3.5.1.1679' of package 'MonoGame.Framework.iOS'.
	Unable to find version '3.3.0.0' of package 'MonoGame.Framework.Android'."
			},
			{ "ModelsAndVertsMG/MonoGame3D.sln",
				@"nuget restore failed:
	Unable to find version '3.5.1.1679' of package 'MonoGame.Framework.iOS'.
	Unable to find version '3.3.0.0' of package 'MonoGame.Framework.Android'."
			},
			{ "MonoGameTvOs/MonoGameTvOs.sln", "build failure: MTOUCH: error MT4116: Could not register the assembly 'MonoGameTvOs': error MT4118: Cannot register two managed types ('MonoGameTvOs.AppDelegate, MonoGameTvOs' and 'MonoGameTvOs.Application, MonoGameTvOs') with the same native name ('AppDelegate')." },
			{ "MultiThreading/MultiThreading.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "Notifications/Notifications.sln", @"nuget restore failed: Unable to find version '20.0.0.4' of package 'Xamarin.Android.Support.v4'." },
			{ "Phoneword/Phoneword.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "Phoneword/Phoneword_Android.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Phoneword/Phoneword_Android.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Phoneword/Phoneword_Cmd.sln", "? (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Phoneword/Phoneword_Cmd.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Phoneword/Phoneword_Win8.sln", "win8 (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Phoneword/Phoneword_Win8.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Phoneword/Phoneword_WP7.sln", "android (!?) (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "Profiling/AndroidAsyncImage/AsyncImageAndroid.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Profiling/AndroidAsyncImage/AsyncImageAndroid.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "RazorTodo/RazorNativeTodo/RazorNativeTodo.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "RazorTodo/RazorTodo/RazorTodo.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "SharingCode/NativeShared.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "SoMA/SoMA.sln",
				@"build errors:
	SoMAViewController.cs(5,7): error CS0246: The type or namespace name `Xamarin' could not be found. Are you missing an assembly reference?
	PhotoScreen.cs(11,7): error CS0246: The type or namespace name `Xamarin' could not be found. Are you missing an assembly reference?
	PhotoScreen.cs(12,7): error CS0246: The type or namespace name `Xamarin' could not be found. Are you missing an assembly reference?
	PhotoScreen.cs(13,7): error CS0246: The type or namespace name `Xamarin' could not be found. Are you missing an assembly reference?
	PhotoScreen.cs(14,7): error CS0246: The type or namespace name `Xamarin' could not be found. Are you missing an assembly reference?
	../Core/ShareItem.cs(2,7): error CS0246: The type or namespace name `SQLite' could not be found. Are you missing an assembly reference?
	../Core/SomaDatabase.cs(2,7): error CS0246: The type or namespace name `SQLite' could not be found. Are you missing an assembly reference?
	../Core/SomaDatabase.cs(13,30): error CS0246: The type or namespace name `SQLiteConnection' could not be found. Are you missing an assembly reference?
	PhotoScreen.cs(19,3): error CS0246: The type or namespace name `MediaPickerController' could not be found. Are you missing an assembly reference?
	PhotoScreen.cs(184,15): error CS0246: The type or namespace name `Service' could not be found. Are you missing an assembly reference?"
			},
			{ "SoMA/SoMA_VisualStudio.sln", "XI/Classic, must be ported to XI/Unified" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/ContactsSample/ContactsSample.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/ContactsSample/ContactsSample.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/GeolocationSample/GeolocationSample.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/GeolocationSample/GeolocationSample.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/MediaPickerSample/MediaPickerSample.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/MediaPickerSample/MediaPickerSample.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/Xamarin.Mobile.Android.Samples.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/Xamarin.Mobile.Android.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.WP.Samples/Xamarin.Mobile.WP.Samples.sln", "windows phone (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.WP.Samples/Xamarin.Mobile.WP.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.WP8.Samples/Xamarin.Mobile.WP8.Samples.sln", "win8 (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.WP8.Samples/Xamarin.Mobile.WP8.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.WinRT.Samples/Xamarin.Mobile.WinRT.Samples.sln", "winrt (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.WinRT.Samples/Xamarin.Mobile.WinRT.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.iOS.Samples/Xamarin.Mobile.iOS.Samples.sln", "XI/Classic, must be ported to XI/Unified" },
			{ "SoMA/iOS/Components/xamarin.social-1.0.1/samples/Xamarin.Social.Sample.Android/Xamarin.Social.Sample.Android.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.social-1.0.1/samples/Xamarin.Social.Sample.Android/Xamarin.Social.Sample.Android.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.social-1.0.1/samples/Xamarin.Social.Sample.iOS/Xamarin.Social.Sample.iOS.sln", "XI/Classic, must be ported to XI/Unified" },
			{ "SpriteSheetDemo/SpriteSheetDemo.sln",
				@"nuget restore failed:
	Unable to find version '1.7.0.0-pre1' of package 'CocosSharp'.
	Unable to find version '1.7.0.0-pre1' of package 'CocosSharp.Forms'.
	Unable to find version '1.5.1.6471' of package 'Xamarin.Forms'.
	Unable to find version '2.0.0.6490' of package 'Xamarin.Forms'.
	Unable to find version '23.0.1.3' of package 'Xamarin.Android.Support.Design'.
	Unable to find version '23.0.1.3' of package 'Xamarin.Android.Support.v4'.
	Unable to find version '23.0.1.3' of package 'Xamarin.Android.Support.v7.AppCompat'.
	Unable to find version '23.0.1.3' of package 'Xamarin.Android.Support.v7.CardView'.
	Unable to find version '23.0.1.3' of package 'Xamarin.Android.Support.v7.MediaRouter'."
			},
			{ "StandardControls/AndroidStandardControls/AndroidStandardControls.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/StandardControls/AndroidStandardControls/AndroidStandardControls.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "TablesLists/AndroidListView/AndroidListView.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/TablesLists/AndroidListView/AndroidListView.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "TablesLists/TablesLists.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "Tasky/Tasky.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "TaskyPortable/TaskyPortable.sln",
				@"nuget restore failed:
	Unable to find version '1.0.11' of package 'sqlite-net-pcl'.
	Unable to find version '0.8.4' of package 'SQLitePCL.raw_basic'.
	Unable to find version '0.7.1' of package 'SQLitePCL.raw_basic'."
			},
			{ "TaskyPro/Tasky.Win8(deprecated)/TaskyWin8.sln", "win8 (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/TaskyPro/Tasky.Win8(deprecated)/TaskyWin8.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "TaskyPro/Tasky.Win81/TaskyWin8.sln", "win8 (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/TaskyPro/Tasky.Win81/TaskyWin8.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "TaskyPro/TaskyPro.sln",
				@"nuget restore failed:
	Unable to find version '1.0.11' of package 'sqlite-net-pcl'.
	Unable to find version '0.7.1' of package 'SQLitePCL.raw_basic'."
			},
			{ "TexturedCubeES30/TexturedCube.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "TipCalc/TipCalc.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "Touch/Touch.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "VisualBasic/TaskyPortableVB/TaskyPortableVB.sln", "build error: /tmp/xamarin-macios-sample-builder/repositories/mobile-samples/VisualBasic/TaskyPortableVB/TaskyiOS/TaskyiOS.csproj: error : Target named 'Build' not found in the project." },
			{ "VisualBasic/TaskyPortableVB/TaskyPortableVisualBasicLibrary/TaskyPortableVisualBasicLibrary.sln", "build error: /tmp/xamarin-macios-sample-builder/repositories/mobile-samples/VisualBasic/TaskyPortableVB/TaskyPortableVisualBasicLibrary/TaskyPortableVisualBasicLibrary.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\"." },
			{ "VisualBasic/XamarinFormsVB/XamarinFormsVB.sln",
				@"nuget restore failed:
	Unable to find version '1.4.4.6392' of package 'Xamarin.Forms'.
	Unable to find version '22.2.1.0' of package 'Xamarin.Android.Support.v4'."
			},
			{ "WCF-Walkthrough/HelloWorld/HelloWorld.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "WalkingGameMG/WalkingGame.sln",
				@"nuget restore failed:
	Unable to find version '3.5.1.1679' of package 'MonoGame.Framework.iOS'.
	Unable to find version '3.5.1.1679' of package 'MonoGame.Framework.Android'."
			},
			{ "Weather/WeatherApp.sln",
				@"nuget restore failed:
	Unable to find version '1.1.10' of package 'Microsoft.Bcl'.
	Unable to find version '1.0.14' of package 'Microsoft.Bcl.Build'.
	Unable to find version '2.2.29' of package 'Microsoft.Net.Http'."
			},
			{ "WebServices/HelloWorld/HelloWorld.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "WebServices/WebServiceSamples/RestSample/RestSample.sln", "build fails with: /tmp/xamarin-macios-sample-builder/repositories/mobile-samples/WebServices/WebServiceSamples/RestSample/RestSample.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\"." },
			{ "WebServices/WebServiceSamples/WebServices.RxNorm/src/WebServices.RxNormSample.sln", "XI/Classic. Must be ported to XI/Unified." },
			{ "XamarinInsights/Android/XamarinInsightsAndroid.sln", "nuget restore failed: Unable to find version '1.10.4.112' of package 'Xamarin.Insights'." },
			{ "XamarinInsights/iOS/XamarinInsightsiOS.sln", "nuget restore failed: Unable to find version '1.10.4.112' of package 'Xamarin.Insights'." },
		};
	}
}
