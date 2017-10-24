using System.Collections.Generic;

using NUnit.Framework;

[Category (CATEGORY)]
public class IosSampleTester : SampleTester
{
	const string REPO = "ios-samples"; // monotouch-samples redirects to ios-samples
	const string CATEGORY = "iossamples"; // categories can't contain dashes
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
			{ "IntroductionToiCloud/iCloudKeyValue/iCloudKeyValue.sln", @"personal code signing key: iOS code signing key 'iPhone Developer: Craig Dunn (6Q937X2U43)' not found in keychain." },
			{ "IntroductionToiCloud/iCloudUIDoc/iCloudUIDoc.sln", @"personal code signing key: iOS code signing key 'iPhone Developer: Craig Dunn (6Q937X2U43)' not found in keychain." },
			{ "ios8/IntroToHealthKit/HKWork.sln", @"personal code signing key: The specified iOS provisioning profile '6303ad69-45e8-4c05-940a-f9c02c8a8de0' could not be found." },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.iOS.Samples/Geolocation/GeolocationSample.sln", @"/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.iOS.Samples/Geolocation/GeolocationSample.sln.metaproj : error MSB3202: The project file ""/private/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.iOS.Samples/Geolocation/GeolocationSample.csproj"" was not found. [/private/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.iOS.Samples/Geolocation/GeolocationSample.sln]" },

			// seems to only fail with msbuild. I can't repro this locally (but I haven't tried much either).
			{ "ios8/SceneKitFSharp/FSSceneKit.sln", "/tmp/xamarin-macios-sample-builder/repositories/ios-samples/ios8/SceneKitFSharp/FSSceneKit/FSSceneKitViewController.fs(6,6): error FS0074: The type referenced through 'System.Runtime.CompilerServices.ExtensionAttribute' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Runtime'. [/private/tmp/xamarin-macios-sample-builder/repositories/ios-samples/ios8/SceneKitFSharp/FSSceneKit/FSSceneKit.fsproj]" },
		};
	}
}
