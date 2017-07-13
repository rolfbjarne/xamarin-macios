﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.Tests;
using Xamarin.Utils;

namespace Xamarin.MMP.Tests
{
	[TestFixture]
	public class TargetFrameworkDetectionTests
	{
		TargetFramework [] XMTargetFrameworks = { TargetFramework.Xamarin_Mac_2_0_Mobile, TargetFramework.Xamarin_Mac_4_5_Full, TargetFramework.Xamarin_Mac_4_5_System };

		string CreateTestExe (string tmpDir)
		{
			string path = Path.Combine (tmpDir, "b.exe");
			File.WriteAllText (Path.Combine (tmpDir, "b.cs"), "public static class EntryPoint { public static void Main () {} }");
			TI.RunAndAssert ("/Library/Frameworks/Mono.framework/Commands/mcs", string.Format ("-out:{0} {1}/b.cs", path, tmpDir), "CreateTestExe");
			return path;
		}

		string GetTestMMPInvocation (string tmpDir, string libPath, TargetFramework targetFramework, bool correctReference = true)
		{
			string xmReference = correctReference ? GetXMReference (targetFramework) : GetWrongXMReference (targetFramework);
			return $"-v -v -v -v -v --output={tmpDir} --arch=x86_64 --sdkroot {Configuration.xcode_root} --minos 10.7 {libPath} --sdk 10.12 --nolink -p --profile:{targetFramework} -a:{xmReference}";
		}

		string GetWrongXMReference (TargetFramework target)
		{
			if (target.Profile == "Mobile")
				return GetXMReference (TargetFramework.Xamarin_Mac_4_5_Full);
			else
				return GetXMReference (TargetFramework.Xamarin_Mac_2_0_Mobile);
		}

		string GetXMReference (TargetFramework target)
		{
			switch (target.Profile)	{
			case "Mobile":
					return $"-a:{Configuration.SdkRootXM}/lib/mono/Xamarin.Mac/Xamarin.Mac.dll";
			case "Full":
			case "System":
					return $"-a:{Configuration.SdkRootXM}/lib/mono/4.5/Xamarin.Mac.dll";
			default:
					throw new System.InvalidOperationException ();
			}
		}

		string MMPPath => TI.FindRootDirectory () + "/Library/Frameworks/Xamarin.Mac.framework/Commands/mmp";

		[Test]
		public void LongProfileStrings_SelectCorrectProfile ()
		{
			MMPTests.RunMMPTest (tmpDir => {
				foreach (var targetProfile in XMTargetFrameworks) {
					string libPath = CreateTestExe (tmpDir);
					string args = GetTestMMPInvocation (tmpDir, libPath, targetProfile);
					string mmpOutput = TI.RunAndAssert (MMPPath, args, "mmp invoke");

					bool mobile = targetProfile.Profile == "Mobile";
					string referenceLine = mmpOutput.Split (Environment.NewLine.ToCharArray ()).First (x => x.StartsWith ("Added assembly ", StringComparison.Ordinal) && x.Contains ("Xamarin.Mac.dll"));

					Assert.True (referenceLine.Contains ("mobile") == mobile, "Selected Reference Line Unexpected: {0} with {1}", referenceLine, targetProfile);
				}
			});
		}

		[Test]
		public void LongProfileStrings_ErrorsWhenWrongXMPassedToRightProfile ()
		{
			MMPTests.RunMMPTest (tmpDir => {
				foreach (var targetProfile in XMTargetFrameworks) {
					string libPath = CreateTestExe (tmpDir);
					string args = GetTestMMPInvocation (tmpDir, libPath, targetProfile, false);
					string buildResults = TI.RunAndAssert (MMPPath, args, "mmp invoke with wrong XM", shouldFail:true);
					Assert.IsTrue (buildResults.Contains ("1407"), "Did not contains 1407 error expected");
				}
			});
		}
	}
}
